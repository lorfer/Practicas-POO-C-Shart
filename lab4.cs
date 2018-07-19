using System;

 class F
    {
        private string x = "Ferreiras";
        private double y = 12.34E12;
        private long z = 987364354;
        protected Byte w = 34;

		public F(){}
        public F(string x, double y, long z, byte w)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }

       

        public virtual void verObjeto()
		{
				Console.WriteLine(x);
                Console.WriteLine(y);
                Console.WriteLine(z);
                Console.WriteLine(w);
                
		}
	class G : F
        {
            private int s;

			public G(){}
            public G(string x, double y, long z, byte w): base(x, y, z, w)
            {
              s = 1514;
            }

            public override void verObjeto()
            {
                Console.WriteLine(x);
                Console.WriteLine(y);
                Console.WriteLine(z);
                Console.WriteLine(w);
                Console.WriteLine(s);


            }
        }

        static void Main(string[] args)
        {
			F  f = new F();
			f.verObjeto();
			Console.WriteLine("\n\n\n");
            G l = new G("Fernando", 12478,1282345, 13);
            l.verObjeto();
            
            Console.ReadKey();
        }

    }