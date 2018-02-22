using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.Windows.Forms;

// All classes in this script

[Serializable]
public class SaveData
{
    // Global timer
    public int globalTimer;

    [XmlArray("Open List"), XmlArrayItem("Ticket")]
    public List<Ticket> openList;

    [XmlArray("Closed List"), XmlArrayItem("Ticket")]
    public List<Ticket> closedList;

    [XmlArray("Categories List"), XmlArrayItem("Category")]
    public List<Category> categoriesList;

    public SaveData()
    {
        this.globalTimer = 0;
        this.openList = new List<Ticket>();
        this.closedList = new List<Ticket>();
        this.categoriesList = new List<Category>();
    }

    public SaveData(int globalTimer, List<Ticket> openList, List<Ticket> closedList, List<Category> categoriesList)
    {
        this.globalTimer = globalTimer;
        this.openList = openList;
        this.closedList = closedList;
        this.categoriesList = categoriesList;
    }
}


[Serializable]
public class Ticket
{
    public string name;         //  Used to find tickets, do not modify
    public string displayName;  // Used to display ticket, do modify.
    public string description;
    public Category category;
    public int timeSpent;

    [XmlArray("Sub Tasks"), XmlArrayItem("Task", typeof(SubTask))]
    public List<SubTask> subTasks;

    public Ticket()
    {
        this.name = "";
        this.displayName = "";
        this.description = "";
        this.category = new Category("", 0);
        this.timeSpent = 0;

        
        subTasks = new List<SubTask>();
    }

    // Constructor
    public Ticket(string name, string displayName, string description, Category category, int timeSpent)
    {
        this.name = name;
        this.displayName = displayName;
        this.description = description;
        this.category = category;
        this.timeSpent = timeSpent;

        
        subTasks = new List<SubTask>();
    }
}

[Serializable]
public class SubTask
{
    public string name;
    public CheckState checkedState;

    public SubTask()
    {
        this.name = "";
        this.checkedState = CheckState.Checked;
    }

    // Constructor
    public SubTask(string name, CheckState checkedState)
    {
        this.name = name;
        this.checkedState = checkedState;
    }
}

[Serializable]
public class Category
{
    public string name;
    public int value;

    public Category()
    {
        this.name = "";
        this.value = -1;
    }

    // Constructor
    public Category(string name, int value)
    {
        this.name = name;
        this.value = value;
    }
}