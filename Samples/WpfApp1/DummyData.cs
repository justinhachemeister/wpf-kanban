﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace WpfApp1
{
    public class DummyData
    {
        public DataTable Table { get; set; }

        public ObservableCollection<CardData> Collection { get; set; } = new ObservableCollection<CardData>();

        public DummyData()
        {
            Table = new DataTable();
            Table.Columns.Add(new DataColumn("Column", typeof(string)));
            Table.Columns.Add(new DataColumn("Lane", typeof(string)));
            Table.Columns.Add(new DataColumn("Title", typeof(string)));
            Table.Rows.Add("Backlog", "lane1", "BL 1");
            Table.Rows.Add("Requested", "lane1", "R 1");
            Table.Rows.Add("Requested", "lane1", "R 2");
            Table.Rows.Add("Design", "lane1", "De 1");
            Table.Rows.Add("Doing", "lane1", "Doi 1");
            Table.Rows.Add("Doing", "lane2", "Doi 2");
            Table.Rows.Add("Done", "lane1", "Don 1");
            Table.Rows.Add("Backlog", "lane2", "BL 2");

            Collection.Add(new CardData() { Column = "Backlog", Lane = "lane1", Number=1, Assignee = "User1", Description = "Something in the backlog Part 1/2", Color = Colors.LightBlue });
            Collection.Add(new CardData() { Column = "Requested", Lane = "lane1", Number = 2, Assignee = "User2", Description = "This is something requested, not started jet" });
            Collection.Add(new CardData() { Column = "Requested", Lane = "lane1", Number = 99999, Assignee = "User1", Description = "This also is something requested ;)" });
            Collection.Add(new CardData() { Column = "Design", Lane = "lane1", Number = 4, Assignee = "User1", Description = "We're designing the hell out of this", Color = Colors.LightBlue });
            Collection.Add(new CardData() { Column = "Doing", Lane = "lane2", Number = 5, Assignee = "User2", Description = "Something we're working on right now", Color = Colors.LightGreen });
            Collection.Add(new CardData() { Column = "Doing", Lane = "lane2", Number = 6, Assignee = "User2", Description = "The other thing we're working on right now", Color = Colors.LightBlue });
            Collection.Add(new CardData() { Column = "Done", Lane = "lane1", Number = 7, Assignee = "User1", Description = "This is done, yeah!" });
            Collection.Add(new CardData() { Column = "Backlog", Lane = "lane2", Number = 8, Assignee = "User1", Description = "Something in the backlog Part 2/2" });
        }
    }
}
