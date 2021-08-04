using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
	public interface IDataAccess
	{
		public void SaveData();
		public List<Product> LoadData();

	}
}
