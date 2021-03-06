﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShaderDBParser
{
	class Block6
	{
		Block6Group group1;
		Block6Group group2;
		Block6Group group3;

		public Block6(BinaryReader p_Reader)
		{
			group1 = new Block6Group(p_Reader);
			group2 = new Block6Group(p_Reader);
			group3 = new Block6Group(p_Reader);
		}

		public List<Block6GroupItem>GetItems()
		{
			List<Block6GroupItem> items = new List<Block6GroupItem>();
			items = items.Concat<Block6GroupItem>(this.group1.getItems()).ToList();
			items = items.Concat<Block6GroupItem>(this.group2.getItems()).ToList();
			items = items.Concat<Block6GroupItem>(this.group3.getItems()).ToList();

			return items;
		}
	}

	class Block6Group
	{
		long itemCount;
		List<Block6GroupItem> items = new List<Block6GroupItem>();

		public Block6Group(BinaryReader p_Reader)
		{
			itemCount = p_Reader.ReadInt32();
			for(int i = 0; i < itemCount; i++)
			{
				items.Add(new Block6GroupItem(p_Reader));
			}
		}

		public List<Block6GroupItem> getItems()
		{
			return this.items;
		}
	}

	class Block6GroupItem {
		public string name = "";
		public string reference;

		public Block6GroupItem(BinaryReader p_Reader)
		{
			char ch;
			while ((int)(ch = p_Reader.ReadChar()) != 0)
				this.name = this.name + ch;

			reference = Util.ByteArrayToString(p_Reader.ReadBytes(16));
			
		}
	}
}
