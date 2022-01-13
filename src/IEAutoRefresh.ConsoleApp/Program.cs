using SHDocVw;
using Spectre.Console;

Console.Title = $"调用IE打开网页，并静默刷新";
AnsiConsole.Write(new FigletText("LingDian").Centered().Color(Color.Red));
string url = AnsiConsole.Ask<string>("[green]请输入要刷新的网页地址：[/]");
Console.Title = $"调用IE打开网页，并静默刷新：{url}";
int timeInterval  = AnsiConsole.Ask<int>("[green]请输入要定时刷新时间，单位毫秒：[/]");
InternetExplorer ie = new();
ie.Navigate(url);
ie.Visible = true;

if (AnsiConsole.Confirm("[green]是否登录完成?[/]"))
{
    while (true)
    {
        ie?.Refresh();
        Thread.Sleep(timeInterval);
    }
}
Console.Read();
