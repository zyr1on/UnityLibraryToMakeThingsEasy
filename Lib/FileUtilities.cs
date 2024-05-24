using UnityEngine;
using System.IO;
using System;
public static class FileUtilities
{
    public static void WriteAsJson(object obj, string path,int type=0)
    {
        if (obj == null)
            throw new NullReferenceException($"The object {nameof(obj)} is null");
        if (path == null)
            throw new NullReferenceException($"The object {nameof(path)} is null");
        if (type == 0) // appends json data
            File.WriteAllText(path, JsonUtility.ToJson(obj));
        else // overwrites json data
            File.AppendAllText(path, JsonUtility.ToJson(obj));
    }
    public static T ReadAsJson<T>(string path)
    {
        if (!File.Exists(path))
            throw new FileNotFoundException($"The file at path {path} was not found.");
        return JsonUtility.FromJson<T>(File.ReadAllText(path));
    }
    public static string ReadFile(string path)
    {
        if (path == null) throw new NullReferenceException($"The object {nameof(path)} is null");
        if (File.Exists(path)) return File.ReadAllText(path);
        else throw new FileNotFoundException($"The file at path {path} was not found.");
    }
    public static void WriteFile(string str, string path,int type=0)
    {
        if (path == null)
            throw new NullReferenceException($"The object {nameof(path)} is null");
        if (str == null)
            throw new NullReferenceException($"The object {nameof(str)} is null");
        if (type == 0)
            File.WriteAllText(path, str);
        else
            File.AppendAllText(path, str);

    }
}
