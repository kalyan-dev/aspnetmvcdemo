using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace aspnetmvcdemo.Models
{
    public class TodoList
    {
        public List<String> todoList;

        public TodoList(int n=10)
        {
            todoList = new List<string>(n);
        }

       public void addItem(String i)
        {
            todoList.Add(i);
        }

        public List<String> getList()
        {
            return todoList;
        }
    }
}