using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;

public static class Functions
{
    // List of categories
    public static List<Category> categories = new List<Category>();

    #region Load Categories to

    // Load Categories information to CheckedListBox
    public static void LoadCategoryDataTo(CheckedListBox target, bool setCheckedDefault)
    {
        for(int i = 0; i < categories.Count; i++)
        {
            // Supress category all since it is not a category but a search function
            if(i != 0)
            {
                target.Items.Add(categories[i].name);
            }
        }

        // Set default check mark
        if (setCheckedDefault)
        {
            target.SetItemCheckState(0, CheckState.Checked);
        }
    }

    // Load Categories information to ListBox
    public static void LoadCategoryDataTo(ListBox target)
    {
        for (int i = 0; i < categories.Count; i++)
        {
            target.Items.Add(categories[i].name);
        }
    }

    // Load categories information to ComboBox
    public static void LoadCategoryDataTo(ComboBox target, int selectIndex)
    {
        foreach (Category c in categories)
        {
            target.Items.Add(c.name);
        }

        target.SelectedIndex = selectIndex;
    }
    #endregion

    // Replaces a category that has been deleted with category unassigned.
    public static void ReplaceCategory(string deleteCategoryName, string replaceCategoryName, List<Ticket> openList, List<Ticket> closedList)
    {
        // Go through openList and replace every item
        foreach(Ticket t in openList)
        {
            if(t.category.name == deleteCategoryName)
            {
                // Set new category
                t.category = new Category(replaceCategoryName, -1);

                // Set new display name
                t.displayName = "[" + t.category.name + "] " + t.name;
            }
        }

        // Go through closedList and replace every item
        foreach (Ticket t in closedList)
        {
            if (t.category.name == deleteCategoryName)
            {
                // Set new category
                t.category = new Category(replaceCategoryName, -1);

                // Set new display name
                t.displayName = "[" + t.category.name + "] " + t.name;
            }
        }

        Category remove = null;

        // Delete the category
        foreach(Category c in categories)
        {
            if(c.name == deleteCategoryName)
            {
                remove = c;
            }
        }

        categories.Remove(remove);
    }

    // Gets a list and returns a category based selection (Showing only what category the user wants)
    public static void ShowBasedSelection(Category category, List<Ticket> list, ListBox target)
    {
        for(int i = 0; i < list.Count; i++)
        {
            if(category.name != "All")
            {
                if (list[i].category.name == category.name)
                {
                    target.Items.Add(list[i].displayName);
                }
            }
            else
            {
                target.Items.Add(list[i].displayName);
            }
        }
    }

    // Save data
    public static void SaveData(SaveData obj, string fileName)
    {
        // Reads and writes c# into xml file
        XmlSerializer serializer = new XmlSerializer(typeof(SaveData));
       
        // Selects the encoding method? (Binary/Stream/Text)
        TextWriter writer = new StreamWriter(fileName);

        // Writes out
        serializer.Serialize(writer, obj);

        // Flush the data and close the stream
        writer.Flush();
        writer.Close();
    }

    // Load data 
    public static SaveData LoadData(string file)
    {
        SaveData serializedData = new SaveData();

        XmlSerializer serializer = new XmlSerializer(typeof(SaveData));
        FileStream stream = new FileStream(file, FileMode.Open, FileAccess.Read, FileShare.Read);
        serializedData = (SaveData)serializer.Deserialize(stream);

        stream.Flush();
        stream.Close();

        return serializedData;
    }
}