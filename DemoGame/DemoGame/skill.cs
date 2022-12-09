namespace DemoGame
{
    class skill
    {
        private int[] tamadas = new int[10];
        private int[] vedekezes = new int[10];
        private int[] maxhap = new int[10];
        private int[] hpregen = new int[10];

        public int[] Tamadas
        {
            get => tamadas;
            set => tamadas = value;
        }
        public int[] Vedekezes
        {
            get => vedekezes;
            set => vedekezes = value;
        }

        public int[] Maxhap
        {
            get => maxhap;
            set => maxhap = value;
        }

        public int[] Hpregen
        {
            get => hpregen;
            set => hpregen = value;
        }
    }
}