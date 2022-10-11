using System.Collections.Concurrent;
using CLI;

var cli = new Main();
cli.Start();

public class Main
{
    private readonly ConcurrentQueue<Task> _inputsQueue;
    private static readonly object _locker = new();
    private readonly Parser _parser; 

    public Main()
    {
        _inputsQueue = new ConcurrentQueue<Task>();
        _parser = new Parser();
    }
    
    // Запуск приложения
    public void Start()
    {
        ReadInput();
    }   
    
    private void ReadInput()
    {
        while (true)
        {
            // Вводим строку
            var currentInput = Console.ReadLine();

            if (currentInput == null)
            {
                continue;
            }
            
            // Создаем задачу, в которой будет обрабатываться команда
            _inputsQueue.Enqueue(
                Task.Run(() => Process(currentInput))
                    .ContinueWith(Output));
        }
    }

    private string Process(string input)
    {
        var result = _parser.Parse(input);
        
        return String.Empty;
    }

    /// <summary>
    /// Выводит результат команды 
    /// </summary>
    /// <param name="task"></param>
    private void Output(Task<string> task)
    {
        lock (_locker)
        {
            var error = task.Exception;
            
            if (error != null)
            {
                Console.WriteLine(error);
                return;
            }

            var result = task.Result;
            
            Console.WriteLine(result);   
        }
    }
}