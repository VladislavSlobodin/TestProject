namespace TestProject;

public static class ExtensionMethods
{
    public static void Hide<T>(this Control control) where T : Control
    {
        foreach (Control c in control.Controls)
        {
            if (c is T t)
            {
                t.Hide();
            }
        }
    }
}
