using System;
using System.IO;
using TablePrinterLibrary;

//needed for correct display of box-drawing characters
Console.OutputEncoding = System.Text.Encoding.UTF8;
TablePrinter tp = new TablePrinter();
//setting the table name
tp.Table.Name = "TABLE PRINTER";
//creating fields
Field ID = new Field() { Name = "ID" };
Field Name = new Field() { Name = "Name" };
Field Phone = new Field() { Name = "Phone" };
Field Country = new Field() { Name = "Country" };
Field City = new Field() { Name = "City" };
Field Address = new Field() { Name = "Address" };
//adding fields to table
tp.Table.Fields.Add(ID);
tp.Table.Fields.Add(Name);
tp.Table.Fields.Add(Phone);
tp.Table.Fields.Add(Country);
tp.Table.Fields.Add(City);
tp.Table.Fields.Add(Address);
//creating entries, adding the columns (key - Field, value - string)
Entry e1 = new Entry();
e1.Columns.Add(ID, "1");
e1.Columns.Add(Name, "Karkki Oy");
e1.Columns.Add(Phone, "(953) 10956");
e1.Columns.Add(Country, "Finland");
e1.Columns.Add(City, "Lappeenranta");
e1.Columns.Add(Address, "Valtakatu 12");
Entry e2 = new Entry();
e2.Columns.Add(ID, "2");
e2.Columns.Add(Name, "Ma Maison");
e2.Columns.Add(Phone, "(514) 555-9022");
e2.Columns.Add(Country, "Canada");
e2.Columns.Add(City, "Quebec");
e2.Columns.Add(Address, "2960 Rue St. Laurent");
Entry e3 = new Entry();
e3.Columns.Add(ID, "3");
e3.Columns.Add(Name, "Pavlova, Ltd.");
e3.Columns.Add(Phone, "(03) 444-2343");
e3.Columns.Add(Country, "Australia");
e3.Columns.Add(City, "Melbourne");
e3.Columns.Add(Address, "74 Rose St. Moonie Ponds");
Entry e4 = new Entry();
e4.Columns.Add(ID, "4");
e4.Columns.Add(Name, "Lyngbysild");
e4.Columns.Add(Phone, "43844108");
e4.Columns.Add(Country, "Denmark");
e4.Columns.Add(City, "Lyngby");
e4.Columns.Add(Address, "Lyngbysild Fiskebakken 10");
Entry e5 = new Entry();
e5.Columns.Add(ID, "5");
e5.Columns.Add(Name, "Gai paturage");
e5.Columns.Add(Phone, "38.76.98.06");
e5.Columns.Add(Country, "France");
e5.Columns.Add(City, "Annecy");
e5.Columns.Add(Address, "Bat. B 3, rue des Alpes");
Entry e6 = new Entry();
e6.Columns.Add(ID, "6");
e6.Columns.Add(Name, "Mayumi's");
e6.Columns.Add(Phone, "(06) 431-7877");
e6.Columns.Add(Country, "Japan");
e6.Columns.Add(City, "Osaka");
e6.Columns.Add(Address, "92 Setsuko Chuo-ku");
Entry e7 = new Entry();
e7.Columns.Add(ID, "7");
e7.Columns.Add(Name, "Leka Trading");
e7.Columns.Add(Phone, "555-8787");
e7.Columns.Add(Country, "Singapore");
e7.Columns.Add(City, "Singapore");
e7.Columns.Add(Address, "471 Serangoon Loop, Suite #402");
//adding entries to the table
tp.Table.Entries.Add(e1);
tp.Table.Entries.Add(e2);
tp.Table.Entries.Add(e3);
tp.Table.Entries.Add(e4);
tp.Table.Entries.Add(e5);
tp.Table.Entries.Add(e6);
tp.Table.Entries.Add(e7);
//printing the table in console
Console.WriteLine(tp.GetTextTable());
//getting the table in HTML format
string html = tp.GetHTMLTable();
//creating html file
string filename = DateTime.Now.ToString();
filename = filename.Replace(".", "");
filename = filename.Replace(" ", "");
filename = filename.Replace(":", "");
//writing HTML file
File.WriteAllText(filename + ".html", html);
Console.ReadKey(true);