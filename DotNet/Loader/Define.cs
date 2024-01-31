namespace ET
{
    public static class Define
    {
#if UNITY_WEBGL
		public static bool IsWebGL = true;
#else
        public static bool IsWebGL = false;
#endif
    }
}