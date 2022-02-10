﻿using MicaForEveryone.Models;
using MicaForEveryone.UI.Models;
using MicaForEveryone.UI.ViewModels;

namespace MicaForEveryone.Interfaces
{
    public interface IRule
    {
        string Name { get; }
        
        bool IsApplicable(TargetWindow target);

        TitlebarColorMode TitleBarColor { get; set; }
        BackdropType BackdropPreference { get; set; }
        bool ExtendFrameIntoClientArea { get; set; }

        RulePaneItem GetPaneItem(ISettingsViewModel parent);
    }
}
