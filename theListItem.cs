using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UoSALoader {
	public class theListItem {
		private int m_offset;
		private int m_parent;

		public theListItem(int offset, int parent) {
			m_parent = parent;
			m_offset = offset;
		}

		public int Offset {
			get { return m_offset; }
			set { m_offset = value; }
		}

		public int Parent {
			get { return m_parent; }
			set { m_parent = value; }
		}
	}
}
