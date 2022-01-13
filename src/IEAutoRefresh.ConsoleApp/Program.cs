using SHDocVw;
using Spectre.Console;

Console.Title = $"【作者：零点 邮箱：857388137@qq.com】 -> 调用IE打开网页，并静默刷新";
AnsiConsole.Write(new FigletText("LingDian").Centered().Color(Color.Red));
string url = AnsiConsole.Ask<string>("[green]请输入要刷新的网页地址：[/]");
int timeInterval = AnsiConsole.Ask<int>("[green]请输入要定时刷新时间，单位毫秒：[/]");

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
