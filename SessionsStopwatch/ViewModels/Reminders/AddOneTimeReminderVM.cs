﻿using System;
using Avalonia.Controls;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using SessionsStopwatch.Models.Reminding;
using SessionsStopwatch.Views.Reminders;

namespace SessionsStopwatch.ViewModels.Reminders;

public partial class AddOneTimeReminderVM : AddReminderBaseVM {
    private TimeSpan lastParsedTime;
    
    [NotifyCanExecuteChangedFor(nameof(AddCommand))]
    [ObservableProperty] 
    private string? timeTextBox;

    protected override Reminder CreateReminder() => new OneTimeReminder(lastParsedTime);

    protected override bool CanAdd() {
        return TimeSpan.TryParse(TimeTextBox, out lastParsedTime);
    }
}