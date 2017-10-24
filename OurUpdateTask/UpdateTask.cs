using OurUpdateTask.Utilities;
using System;
using System.Diagnostics;
using Windows.ApplicationModel.Background;

namespace OurUpdateTask
{
    public sealed class UpdateTask : IBackgroundTask
    {
        public void Run(IBackgroundTaskInstance taskInstance)
        {
            ToastHelper.PopToast("Hello world", "From update task");
        }
    }
}
