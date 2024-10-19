string selectBody;
int a = 10;
List<string> todoList = new List<string>();

Console.WriteLine("Hello!");

do
{
    body();

    if (selectBody == "A" || selectBody == "a")
    {
        addTodo(selectBody);
    }
    else if (selectBody == "R" || selectBody == "r")
    {
        removeTodo(selectBody, todoList);
    }
    else if (selectBody == "S" || selectBody == "s")
    {
        seeAll(selectBody, todoList);
    }
    else if (selectBody == "E" || selectBody == "e")
    {
        exit(selectBody);
        break;
    }

} while (true);



Console.ReadLine();

void addTodo(string selectBody)
{

    bool isValidateAddNew = false;
    while (!isValidateAddNew)
    {

        Console.WriteLine("\n\n");
        Console.WriteLine("\tEnter the todo description:");
        var addnew = Console.ReadLine();
        bool check = todoList.Contains(addnew);
        if (addnew == "")
        {
            Console.WriteLine("Adding is emty");



        }
        else if (check)
        {
            Console.WriteLine("\n\tThe discription must be unique");


        }
        else
        {
            isValidateAddNew = true;
            todoList.Add(addnew);
            Console.WriteLine($"\n\tTODO suscessfully Added : {addnew}");
        }
    }

}

void removeTodo(string selectBody, List<string> todoList)
{
    var selectItem = "";

    for (int i = 0; i < todoList.Count; i++)
    {
        var selecetItem = $"{i}.{todoList[i]}";
        Console.WriteLine($"{i}.{todoList[i]}");
    }

    if (todoList.Count == 0)
    {
        Console.WriteLine("no todos have been added yet");
        return;

    }
    bool isIndexValidate = false;
    while (!isIndexValidate)
    {
        Console.WriteLine("Select index of todos you want to remove");
        seeAll(selectBody, todoList);
        var userInput = Console.ReadLine();
        if (userInput == "")
        {
            Console.WriteLine("selected index can't be empty");
            continue;
        }
        int result;
        if (int.TryParse(userInput, out result) && result >= 0)
        {
            var todosToBeRemoved = todoList[result];
            todoList.RemoveAt(result);
            isIndexValidate = true;
            Console.WriteLine("TODO Remove : " + todosToBeRemoved);
        }
        else
        {
            Console.WriteLine("This given index is not valid");
        }


    }
}

void seeAll(string selectBody, List<string> todoList)
{
    Console.WriteLine("\n\t\t\tAll Todos");
    if (todoList.Count == 0)
    {
        Console.WriteLine("\tNo todos entering Yet");

    }
    else
    {
        for (int i = 0; i < todoList.Count; i++)
        {

            Console.WriteLine($"{i}.{todoList[i]}");
        }
    }


}

void exit(string selectBody)
{
    Console.WriteLine("\n\n\n\nExit");

}
void body()
{
    Console.WriteLine("\nWhat do you want to?");
    Console.WriteLine("\t[S]ee all todos");
    Console.WriteLine("\t[A]dd a todo");
    Console.WriteLine("\t[R]emove a todo");
    Console.WriteLine("\t[E]xit");
    selectBody = Console.ReadLine();

}


