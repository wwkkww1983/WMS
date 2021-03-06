﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CIT.Wcf.Utils;
using CIT.MES;
using Warehouse.BLL;

namespace Warehouse.UI
{
    public partial class ucInventoryDetailManager : UserControl
    {
        public ucInventoryDetailManager()
        {
            InitializeComponent();
            dgv_inventoryManager.AutoGenerateColumns = false;
        }

        private void btn_query_Click(object sender, EventArgs e)
        {
            QueryData();
            new PubUtils().ShowNoteOKMsg("查询成功！");
        }
        private void QueryData()
        {
            string strWhere = " Where 1=1";
            if (txt_inventoryCode.Text.Trim() != "")
            {
                strWhere += string.Format(" And A.InventoryCode='{0}'", txt_inventoryCode.Text.Trim());
            }
            if (txt_ReelId.Text.Trim() != "")
            {
                string reelid = string.Empty;
                strWhere += string.Format(" And B.ReelId='{0}'", txt_ReelId.Text.Trim());
            }
            if (cbo_houseName.Text != "")
            {
                strWhere += string.Format(" And A.HouseCode='{0}'", cbo_houseName.SelectedValue.ToString());
            }
            if (cbo_status.Text != "")
            {
                if (cbo_status.Text == "未盘")
                {
                    strWhere += string.Format(" And B.Status='1'");
                }
                else if (cbo_status.Text == "已盘")
                {
                    strWhere += string.Format(" And B.Status='0'");
                }
            }
            DataTable dt = Bll_Inventory_ti.QueryDetail(strWhere);
            dgv_inventoryManager.DataSource = dt;
        }
        /// <summary>
        /// 初始化仓库
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ucInventoryDetailManager_Load(object sender, EventArgs e)
        {
            string strSql = "Select Storage_Name,Storage_SN from T_Bllb_Storage_tbs";
            DataTable dt = NMS.QueryDataTable(PubUtils.uContext, strSql);
            DataRow dr = dt.NewRow();
            dr["Storage_Name"] = "";
            dr["Storage_SN"] = "-1";
            dt.Rows.InsertAt(dr, 0);
            cbo_houseName.DataSource = dt;
            cbo_houseName.DisplayMember = "Storage_Name";
            cbo_houseName.ValueMember = "Storage_SN";
        }

        private void dgv_inventoryManager_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            new PubUtils().ShowMsg(dgv_inventoryManager, e);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            QueryData();
        }
    }
}
