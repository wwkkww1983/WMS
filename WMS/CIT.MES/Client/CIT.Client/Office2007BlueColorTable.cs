using System.Collections.Generic;
using System.Drawing;

namespace CIT.Client
{
	public class Office2007BlueColorTable : OfficeColorTable
	{
		private PanelColors m_panelColorTable;

		public override PanelColors PanelColorTable
		{
			get
			{
				if (m_panelColorTable == null)
				{
					m_panelColorTable = new PanelColorsOffice2007Blue();
				}
				return m_panelColorTable;
			}
		}

		protected override void InitColors(Dictionary<KnownColors, Color> rgbTable)
		{
			rgbTable[KnownColors.ButtonPressedBorder] = Color.FromArgb(255, 189, 105);
			rgbTable[KnownColors.ButtonPressedGradientBegin] = Color.FromArgb(248, 181, 106);
			rgbTable[KnownColors.ButtonPressedGradientEnd] = Color.FromArgb(255, 208, 134);
			rgbTable[KnownColors.ButtonPressedGradientMiddle] = Color.FromArgb(251, 140, 60);
			rgbTable[KnownColors.ButtonSelectedBorder] = Color.FromArgb(255, 189, 105);
			rgbTable[KnownColors.ButtonSelectedGradientBegin] = Color.FromArgb(255, 245, 204);
			rgbTable[KnownColors.ButtonSelectedGradientEnd] = Color.FromArgb(255, 219, 117);
			rgbTable[KnownColors.ButtonSelectedGradientMiddle] = Color.FromArgb(255, 231, 162);
			rgbTable[KnownColors.ButtonSelectedHighlightBorder] = Color.FromArgb(255, 189, 105);
			rgbTable[KnownColors.CheckBackground] = Color.FromArgb(255, 227, 149);
			rgbTable[KnownColors.CheckSelectedBackground] = Color.FromArgb(254, 128, 62);
			rgbTable[KnownColors.GripDark] = Color.FromArgb(111, 157, 217);
			rgbTable[KnownColors.GripLight] = Color.FromArgb(255, 255, 255);
			rgbTable[KnownColors.ImageMarginGradientBegin] = Color.FromArgb(233, 238, 238);
			rgbTable[KnownColors.MenuBorder] = Color.FromArgb(134, 134, 134);
			rgbTable[KnownColors.MenuItemBorder] = Color.FromArgb(255, 189, 105);
			rgbTable[KnownColors.MenuItemPressedGradientBegin] = Color.FromArgb(227, 239, 255);
			rgbTable[KnownColors.MenuItemPressedGradientEnd] = Color.FromArgb(152, 186, 230);
			rgbTable[KnownColors.MenuItemPressedGradientMiddle] = Color.FromArgb(222, 236, 255);
			rgbTable[KnownColors.MenuItemSelected] = Color.FromArgb(255, 238, 194);
			rgbTable[KnownColors.MenuItemSelectedGradientBegin] = Color.FromArgb(255, 245, 204);
			rgbTable[KnownColors.MenuItemSelectedGradientEnd] = Color.FromArgb(255, 223, 132);
			rgbTable[KnownColors.MenuItemText] = Color.FromArgb(0, 0, 0);
			rgbTable[KnownColors.MenuStripGradientBegin] = Color.FromArgb(191, 219, 255);
			rgbTable[KnownColors.MenuStripGradientEnd] = Color.FromArgb(191, 219, 255);
			rgbTable[KnownColors.OverflowButtonGradientBegin] = Color.FromArgb(167, 204, 251);
			rgbTable[KnownColors.OverflowButtonGradientEnd] = Color.FromArgb(101, 147, 207);
			rgbTable[KnownColors.OverflowButtonGradientMiddle] = Color.FromArgb(167, 204, 251);
			rgbTable[KnownColors.RaftingContainerGradientBegin] = Color.FromArgb(191, 219, 255);
			rgbTable[KnownColors.RaftingContainerGradientEnd] = Color.FromArgb(191, 219, 255);
			rgbTable[KnownColors.SeparatorDark] = Color.FromArgb(173, 209, 255);
			rgbTable[KnownColors.SeparatorLight] = Color.FromArgb(255, 255, 255);
			rgbTable[KnownColors.StatusStripGradientBegin] = Color.FromArgb(227, 239, 255);
			rgbTable[KnownColors.StatusStripGradientEnd] = Color.FromArgb(173, 209, 255);
			rgbTable[KnownColors.StatusStripText] = Color.FromArgb(21, 66, 139);
			rgbTable[KnownColors.ToolStripBorder] = Color.FromArgb(111, 157, 217);
			rgbTable[KnownColors.ToolStripContentPanelGradientBegin] = Color.FromArgb(191, 219, 255);
			rgbTable[KnownColors.ToolStripContentPanelGradientEnd] = Color.FromArgb(101, 145, 205);
			rgbTable[KnownColors.ToolStripDropDownBackground] = Color.FromArgb(250, 250, 250);
			rgbTable[KnownColors.ToolStripGradientBegin] = Color.FromArgb(227, 239, 255);
			rgbTable[KnownColors.ToolStripGradientEnd] = Color.FromArgb(152, 186, 230);
			rgbTable[KnownColors.ToolStripGradientMiddle] = Color.FromArgb(222, 236, 255);
			rgbTable[KnownColors.ToolStripPanelGradientBegin] = Color.FromArgb(191, 219, 255);
			rgbTable[KnownColors.ToolStripPanelGradientEnd] = Color.FromArgb(191, 219, 255);
			rgbTable[KnownColors.ToolStripText] = Color.FromArgb(0, 0, 0);
		}
	}
}
