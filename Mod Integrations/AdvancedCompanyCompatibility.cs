﻿namespace InsanityRemastered.ModIntegration
{
    public class AdvancedCompanyCompatibility
    {
        public static bool nightVision;

        internal static void UnequipHeadLightUtility()
        {
            nightVision = false;
        }

        internal static void HeadLightUtilityUse(bool on)
        {
            if (on)
            {
                nightVision = true;
            }
            else
            {
                nightVision = false;
            }
        }
    }
}