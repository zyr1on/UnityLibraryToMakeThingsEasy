// using ScreenUtilities;
// ScreenBounds bounds = ScreenBounds.GetScreenBounds();
// bounds.min.x bounds.max.x bounds.min.y bounds.max.x
using UnityEngine;
namespace ScreenUtilities {
    public struct ScreenBounds {
        public Vector2 Min { get; set; }
        public Vector2 Max { get; set; }
        public ScreenBounds(Vector2 min, Vector2 max) {
            Min = min;
            Max = max;
        }
        public static ScreenBounds GetScreenBounds() {
            Vector3 bottomLeft = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, Camera.main.nearClipPlane));
            Vector3 topRight = Camera.main.ViewportToWorldPoint(new Vector3(1, 1, Camera.main.nearClipPlane));
            return new ScreenBounds(new Vector2(bottomLeft.x, bottomLeft.y), new Vector2(topRight.x, topRight.y));
        }
    }
}
