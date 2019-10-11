using JetBrains.Annotations;
using NFive.SDK.Core.Models;

namespace NFive.SDK.Server.Extensions
{
	[PublicAPI]
	public static class VectorExtensions
	{
		/// <summary>
		/// Coverts to <see cref="Vector3" />.
		/// </summary>
		/// <param name="vector3">The CitizenFX Vector3 to convert.</param>
		/// <returns>The <see cref="Vector3" />.</returns>
		public static Vector3 ToVector3(this CitizenFX.Core.Vector3 vector3) => new Vector3(vector3.X, vector3.Y, vector3.Z);

		/// <summary>
		/// Converts to CitizenFX Vector3.
		/// </summary>
		/// <param name="vector3">The <see cref="Vector3" /> to convert.</param>
		/// <returns>The CitizenFX Vector3.</returns>
		public static CitizenFX.Core.Vector3 ToCitVector3(this Vector3 vector3) => new CitizenFX.Core.Vector3(vector3.X, vector3.Y, vector3.Z);
	}
}
