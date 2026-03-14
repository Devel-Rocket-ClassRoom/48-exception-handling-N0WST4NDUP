using System;

public class FilePathValidator
{

    public void ValidatePath(string path)
    {
        string[] inhibits = { "<", ">", "|", "\"", "*", "?" };

        if (string.IsNullOrEmpty(path)) throw new ArgumentNullException("", "[ArgumentNull 오류] 경로는 null이거나 비어있을 수 없습니다.");
        if (path.Length > 260) throw new ArgumentOutOfRangeException("", "[ArgumentOutOfRange 오류] 경로 길이가 260자를 초과합니다.");
        foreach (string inhibit in inhibits)
        {
            if (path.Contains(inhibit)) throw new ArgumentException($"[Argument 오류] 경로에 금지 문자 '{inhibit}'가 포함되어 있습니다.");
        }
        Console.WriteLine($"경로가 유효합니다: {path}");
    }

    public void ValidateExtension(string path, string[] allowedExtensions)
    {
        string ext = path.Substring(path.LastIndexOf("."));

        foreach (string extention in allowedExtensions)
        {
            if (ext == extention)
            {
                Console.WriteLine($"확장자가 유효합니다: {ext}");
                return;
            }
        }
        throw new ArgumentException($"[Argument 오류] 허용되지 않은 확장자입니다: {ext}");
    }
}