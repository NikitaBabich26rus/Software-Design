using System.Collections.Concurrent;

namespace CLI.Infrastructure;

public static class Environment
{
    /// <summary>
    /// Задается при инициализации
    /// </summary>
    private static ConcurrentDictionary<string, string> _environments;
    
    /// <summary>
    /// Получаем значение переменной среды
    /// </summary>
    /// <returns>
    /// Если PATH, то возвращает пути
    /// Если internal env, то возращает ее значение 
    /// </returns>
    public static string GetVariableValue(string variable)
    {

        return string.Empty;
    }
    
    /// <summary>
    /// Добавляем переменную среды и ее значение
    /// Если переменная уже есть, то перезаписываем ее значение
    /// </summary>
    public static void AddVariable(string variable, string value)
    {

    }
    
    /// <summary>
    /// Получаем путь к тому, где лежит исполняемый файл внешней команды
    /// Передаем название внешней команды
    /// </summary>
    /// <param name="variable"></param>
    public static void GetPathToExternalCommand(string variable)
    {

    }
}