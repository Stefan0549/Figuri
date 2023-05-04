using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuri
{
    internal class Pravougalnik:Shape
    {
		public Pravougalnik(int lenght, int width, string name):base(name)
		{
			this.lenght=lenght;
			this.width = width;
		}

		private int lenght;
		private int width;

		public int Width
		{
			get { return width; }
			set { width = value; }
		}

		public int Lenght
		{
			get { return lenght; }
			set { lenght = value; }
		}

	}
}
