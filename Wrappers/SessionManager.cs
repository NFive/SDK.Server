using System;
using System.Collections.Generic;
using JetBrains.Annotations;
using NFive.SDK.Core.Models.Player;
using NFive.SDK.Server.Events;
using NFive.SDK.Server.Rpc;

namespace NFive.SDK.Server.Wrappers
{
	/// <summary>
	/// Wrapper library for accessing session data from external plugins.
	/// </summary>
	[PublicAPI]
	public class SessionManager
	{
		/// <summary>
		/// The controller event manager.
		/// </summary>
		protected readonly IEventManager Events;

		/// <summary>
		/// The controller RPC handler.
		/// </summary>
		protected readonly IRpcHandler Rpc;

		/// <summary>
		/// Occurs when a client starts connecting to the server.
		/// </summary>
		public event EventHandler<ClientDeferralsEventArgs> ClientConnecting;

		/// <summary>
		/// Occurs when a user starts creating.
		/// </summary>
		public event EventHandler<ClientEventArgs> UserCreating;

		/// <summary>
		/// Occurs when a user has been created.
		/// </summary>
		public event EventHandler<ClientUserEventArgs> UserCreated;

		/// <summary>
		/// Occurs when a session starts creating.
		/// </summary>
		public event EventHandler<ClientEventArgs> SessionCreating;

		/// <summary>
		/// Occurs when a session has been created.
		/// </summary>
		public event EventHandler<ClientSessionDeferralsEventArgs> SessionCreated;

		/// <summary>
		/// Occurs when a client finishes connecting to the server.
		/// </summary>
		public event EventHandler<ClientSessionEventArgs> ClientConnected;

		/// <summary>
		/// Occurs when a client starts reconnecting to the server.
		/// </summary>
		public event EventHandler<ClientReconnectEventArgs> ClientReconnecting;

		/// <summary>
		/// Occurs when a client has been reconnected to the server.
		/// </summary>
		public event EventHandler<ClientReconnectEventArgs> ClientReconnected;

		/// <summary>
		/// Occurs when a client finishes disconnecting to the server.
		/// </summary>
		public event EventHandler<ClientEventArgs> ClientDisconnecting;

		/// <summary>
		/// Occurs when a client has been disconnected.
		/// </summary>
		public event EventHandler<ClientSessionEventArgs> ClientDisconnected;

		/// <summary>
		/// Occurs when a client starts initializing.
		/// </summary>
		public event EventHandler<ClientEventArgs> ClientInitializing;

		/// <summary>
		/// Occurs when a client has been initialized.
		/// </summary>
		public event EventHandler<ClientSessionEventArgs> ClientInitialized;

		/// <summary>
		/// Occurs when a session has timed out.
		/// </summary>
		public event EventHandler<ClientSessionEventArgs> SessionTimedOut;

		/// <summary>
		/// Gets the maximum number of players.
		/// </summary>
		/// <value>
		/// The maximum number of players.
		/// </value>
		public ushort MaxPlayers;// => this.Events.Request<ushort>(SessionEvents.GetMaxPlayers);

		/// <summary>
		/// Gets the current sessions count.
		/// </summary>
		/// <value>
		/// The current sessions count.
		/// </value>
		public int CurrentSessionsCount;// => this.Events.Request<int>(SessionEvents.GetCurrentSessionsCount);

		/// <summary>
		/// Gets the current sessions.
		/// </summary>
		/// <value>
		/// The current sessions.
		/// </value>
		public List<Session> CurrentSessions;// => this.Events.Request<List<Session>>(SessionEvents.GetCurrentSessions);

		/// <summary>
		/// Initializes a new instance of the <see cref="SessionManager"/> class.
		/// </summary>
		/// <param name="events">The controller event manager.</param>
		/// <param name="rpc">The controller RPC handler.</param>
		public SessionManager(IEventManager events, IRpcHandler rpc)
		{
			this.Events = events;
			this.Rpc = rpc;

			this.Events.On<IClient, Deferrals>(SessionEvents.ClientConnecting, (e, c, d) => this.ClientConnecting?.Invoke(this, new ClientDeferralsEventArgs(c, d)));
			this.Events.On<IClient>(SessionEvents.UserCreating, (e, c) => this.UserCreating?.Invoke(this, new ClientEventArgs(c)));
			this.Events.On<IClient, User>(SessionEvents.UserCreated, (e, c, u) => this.UserCreated?.Invoke(this, new ClientUserEventArgs(c, u)));
			this.Events.On<IClient>(SessionEvents.SessionCreating, (e, c) => this.SessionCreating?.Invoke(this, new ClientEventArgs(c)));
			this.Events.On<IClient, Session, Deferrals>(SessionEvents.SessionCreated, (e, c, s, d) => this.SessionCreated?.Invoke(this, new ClientSessionDeferralsEventArgs(c, s, d)));
			this.Events.On<IClient, Session>(SessionEvents.ClientConnected, (e, c, s) => this.ClientConnected?.Invoke(this, new ClientSessionEventArgs(c, s)));

			this.Events.On<IClient, Session, Session>(SessionEvents.ClientReconnecting, (e, c, o, n) => this.ClientReconnecting?.Invoke(this, new ClientReconnectEventArgs(c, o, n)));
			this.Events.On<IClient, Session, Session>(SessionEvents.ClientReconnected, (e, c, o, n) => this.ClientReconnected?.Invoke(this, new ClientReconnectEventArgs(c, o, n)));

			this.Events.On<IClient>(SessionEvents.ClientDisconnecting, (e, c) => this.ClientDisconnecting?.Invoke(this, new ClientEventArgs(c)));
			this.Events.On<IClient, Session>(SessionEvents.ClientDisconnected, (e, c, s) => this.ClientDisconnected?.Invoke(this, new ClientSessionEventArgs(c, s)));

			this.Events.On<IClient>(SessionEvents.ClientInitializing, (e, c) => this.ClientInitializing?.Invoke(this, new ClientEventArgs(c)));
			this.Events.On<IClient, Session>(SessionEvents.ClientInitialized, (e, c, s) => this.ClientInitialized?.Invoke(this, new ClientSessionEventArgs(c, s)));

			this.Events.On<IClient, Session>(SessionEvents.SessionTimedOut, (e, c, s) => this.SessionTimedOut?.Invoke(this, new ClientSessionEventArgs(c, s)));
		}

		/// <summary>
		/// Disconnects the specified session from the server.
		/// </summary>
		/// <param name="session">The session to disconnect.</param>
		/// <param name="message">The disconnect message.</param>
		public void Disconnect(Session session, string message = "Disconnected by server")
		{
			Disconnect(session.Id, message);
		}

		/// <summary>
		/// Disconnects the specified session from the server.
		/// </summary>
		/// <param name="id">The session identifier to disconnect.</param>
		/// <param name="message">The disconnect message.</param>
		public void Disconnect(Guid id, string message = "Disconnected by server")
		{
			this.Rpc.Event(SessionEvents.DisconnectPlayer).Trigger(id, message);
		}
	}
}
