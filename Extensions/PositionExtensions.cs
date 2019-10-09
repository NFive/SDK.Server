using JetBrains.Annotations;
using NFive.SDK.Core.Models;

namespace NFive.SDK.Server.Extensions
{
	[PublicAPI]
	public static class PositionExtensions
	{
		/// <summary>
		/// Coverts to <see cref="Vector3" />.
		/// </summary>
		/// <param name="pos">The <see cref="Position" /> to convert.</param>
		/// <returns>The <see cref="Vector3" />.</returns>
		public static Vector3 ToVector3(this Position pos) => new Vector3
		{
			X = pos.X,
			Y = pos.Y,
			Z = pos.Z
		};

		/// <summary>
		/// Converts to CitizenFX Vector3.
		/// </summary>
		/// <param name="position">The <see cref="Position" /> to convert.</param>
		/// <returns>The CitizenFX Vector3.</returns>
		public static CitizenFX.Core.Vector3 ToCitVector3(this Position position) => new CitizenFX.Core.Vector3(position.X, position.Y, position.Z);
	}
}
