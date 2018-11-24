namespace DesignPatterns.FactoryMethod
{
    public static class CreatorFactory
    {
        public static IScreen ScreenFactory(ScreenType screenType)
        {
            IScreen screen = null;

            switch (screenType)
            {
                case ScreenType.Web:
                    screen = new WebScreem();
                    break;
                case ScreenType.Windows:
                    screen = new WindowsScreen();
                    break;
            }

            return screen;
        }
    }
}