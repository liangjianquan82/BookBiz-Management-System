// File:    OrderType.cs
// Author:  Liang Jianquan
// ID:      2201546
// Course:  420-942-VA APPLICATION DEVELOPMENT 1 (DESKTOP)
// Purpose: Definition of Class OrderType

using System;

namespace BookBiz_Management_System
{
    public class OrderType
    {
        private int orderTypeId;
        private string orderTypeName;

        public System.Collections.Generic.List<OrderTable> orderTable;

        /// <summary>
        /// Property for collection of OrderTable
        /// </summary>
        /// <pdGenerated>Default opposite class collection property</pdGenerated>
        public System.Collections.Generic.List<OrderTable> OrderTable
        {
            get
            {
                if (orderTable == null)
                    orderTable = new System.Collections.Generic.List<OrderTable>();
                return orderTable;
            }
            set
            {
                RemoveAllOrderTable();
                if (value != null)
                {
                    foreach (OrderTable oOrderTable in value)
                        AddOrderTable(oOrderTable);
                }
            }
        }

        public int OrderTypeId { get => orderTypeId; set => orderTypeId = value; }
        public string OrderTypeName { get => orderTypeName; set => orderTypeName = value; }

        /// <summary>
        /// Add a new OrderTable in the collection
        /// </summary>
        /// <pdGenerated>Default Add</pdGenerated>
        public void AddOrderTable(OrderTable newOrderTable)
        {
            if (newOrderTable == null)
                return;
            if (this.orderTable == null)
                this.orderTable = new System.Collections.Generic.List<OrderTable>();
            if (!this.orderTable.Contains(newOrderTable))
            {
                this.orderTable.Add(newOrderTable);
                newOrderTable.OrderType = this;
            }
        }

        /// <summary>
        /// Remove an existing OrderTable from the collection
        /// </summary>
        /// <pdGenerated>Default Remove</pdGenerated>
        public void RemoveOrderTable(OrderTable oldOrderTable)
        {
            if (oldOrderTable == null)
                return;
            if (this.orderTable != null)
                if (this.orderTable.Contains(oldOrderTable))
                {
                    this.orderTable.Remove(oldOrderTable);
                    oldOrderTable.OrderType = null;
                }
        }

        /// <summary>
        /// Remove all instances of OrderTable from the collection
        /// </summary>
        /// <pdGenerated>Default removeAll</pdGenerated>
        public void RemoveAllOrderTable()
        {
            if (orderTable != null)
            {
                System.Collections.ArrayList tmpOrderTable = new System.Collections.ArrayList();
                foreach (OrderTable oldOrderTable in orderTable)
                    tmpOrderTable.Add(oldOrderTable);
                orderTable.Clear();
                foreach (OrderTable oldOrderTable in tmpOrderTable)
                    oldOrderTable.OrderType = null;
                tmpOrderTable.Clear();
            }
        }

    }
}