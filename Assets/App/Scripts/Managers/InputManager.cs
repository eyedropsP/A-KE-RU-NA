using UnityEngine;

namespace Akeruna.Managers
{
	public static class InputManager
	{
		private static Vector2 TouchPosition = Vector2.zero;

		public static TouchInfo GetTouch()
		{
			if (Application.isEditor)
			{
				if (Input.GetMouseButtonDown(0))
					return TouchInfo.Began;

				if (Input.GetMouseButton(0))
					return TouchInfo.Moved;

				if (Input.GetMouseButtonUp(0))
					return TouchInfo.Ended;
			}
			else
			{
				if (Input.touchCount > 0)
					return (TouchInfo) (int) Input.GetTouch(0).phase;
			}

			return TouchInfo.None;
		}

		public static Vector2 GetTouchPosition()
		{
			if (Application.isEditor)
			{
				var touch = GetTouch();
				if (touch != TouchInfo.None)
				{
					return Input.mousePosition;
				}
			}
			else
			{
				if (Input.touchCount <= 0) return Vector2.zero;
				var touch = Input.GetTouch(0);
				TouchPosition.x = touch.position.x;
				TouchPosition.y = touch.position.y;
				return TouchPosition;
			}

			return Vector2.zero;
		}

		public static Vector2 GetTouchWorldPosition(Camera camera)
		{
			return camera.ScreenToWorldPoint(GetTouchPosition());
		}
	}
}