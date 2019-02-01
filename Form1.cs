using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc
{
	public partial class FormCalc : Form
	{
		public FormCalc()
		{
			InitializeComponent();
		}

		// Целые числа
		byte 0..255
		short -32768..32767
		int -2147483648..2147483647
		long -9223372036854775808..9223372036854775807

		sbyte -128..127
		ushort 0..65535
		uint 0..4294967295
		ulong 0..18446744073709551615

		//Числа с плавающей точкой
		float -3.40282347E+38F..3.40282347E+38F
		double -1.7976931348623157e+308..1.7976931348623157e+308

		//Символ
		char \u0000..\uffff

		//Строка
		string

		//Логические переменные
		bool true или false


	}
}
