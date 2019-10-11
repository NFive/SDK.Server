using JetBrains.Annotations;
using NFive.SDK.Core.Models;

namespace NFive.SDK.Server.Events
{
	[PublicAPI]
	public interface IExplosionEvent
	{
		int OwnerNetId { get; }

		int ExplosionType { get; }

		float DamageScale { get; }

		float CameraShake { get; }

		Position Position { get; }

		bool IsAudible { get; }

		bool IsInvisible { get; }

		void Cancel();
	}
}
