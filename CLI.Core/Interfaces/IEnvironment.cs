namespace CLI.Core.Interfaces;

public interface IEnvironment
{
    /// <summary>
    /// Получаем значение переменной среды
    /// </summary>
    /// <returns>
    /// Если PATH, то возвращает пути
    /// Если internal env, то возращает ее значение 
    /// </returns>
    public string GetVariableValue(string variable);

    /// <summary>
    /// Добавляем переменную среды и ее значение
    /// Если переменная уже есть, то перезаписываем ее значение
    /// </summary>
    public void AddVariable(string variable, string value);

    /// <summary>
    /// Получаем путь к тому, где лежит исполняемый файл внешней команды
    /// Передаем название внешней команды
    /// </summary>
    /// <param name="variable"></param>
    public void GetPathToExternalCommand(string variable);
}