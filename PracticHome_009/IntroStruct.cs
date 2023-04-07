namespace PracticHome_009
{
    struct IntroStruct
    {
        public void Intro()
        {
            Console.WriteLine("Welcome to our Bank");
        }

        public void Loading()
        {
            Console.WriteLine("Loading...");
            for (int i = 0; i < 4; i++)
            {
                Console.Write('.');
                Thread.Sleep(500);
            }
        }
    }
}
