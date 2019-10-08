using System;
using JetBrains.Annotations;
using NFive.SDK.Core.Helpers;
using NFive.SDK.Core.Models;

namespace NFive.SDK.Server.Extensions
{
	[PublicAPI]
	public static class VectorExtensions
	{
		public static Vector2 RotateAround(this Vector3 position, float radius, float angle) =>
			new Vector2(
				position.X + radius * (float)Math.Cos(angle * Math.PI / 180),
				position.Y - radius * (float)Math.Sin(angle * Math.PI / 180)
			);

		public static Vector3 TranslateDir(this Vector3 pos, float angleInDegrees, float distance) =>
			new Vector3(
				pos.X + (float)Math.Cos(CitizenFX.Core.MathUtil.DegreesToRadians(angleInDegrees)) * distance,
				pos.Y + (float)Math.Sin(CitizenFX.Core.MathUtil.DegreesToRadians(angleInDegrees)) * distance,
				pos.Z
			);

		public static Vector3 Lerp(Vector3 pos1, Vector3 pos2, float normalizedInterval) =>
			new Vector3(
				MathHelpers.Lerp(pos1.X, pos2.X, normalizedInterval),
				MathHelpers.Lerp(pos1.Y, pos2.Y, normalizedInterval),
				MathHelpers.Lerp(pos1.Z, pos2.Z, normalizedInterval)
			);

		public static Position ToPosition(this Vector3 vector3) => new Position(vector3.X, vector3.Y, vector3.Z);

		public static Vector3 ToVector3(this CitizenFX.Core.Vector3 vector3) => new Vector3(vector3.X, vector3.Y, vector3.Z);

		public static CitizenFX.Core.Vector3 ToCitVector3(this Vector3 vector3) => new CitizenFX.Core.Vector3(vector3.X, vector3.Y, vector3.Z);
	}
}
