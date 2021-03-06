﻿// This file is part of ScreenRecorder
//  
// ScreenRecorder  is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// 
// ScreenRecorder is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with ScreenRecorder.  If not, see <http://www.gnu.org/licenses/>.

using System.Windows;
using CAM.Tools.Helper;
using CAM.Tools.ViewModel;

namespace CAM.Tools.Views
{
    /// <summary>
    ///     Interaction logic for ToolsView.xaml
    /// </summary>
    public partial class ToolsView
    {
        private readonly VisualThreadedHelper myVisualThreadedHelper;

        public ToolsView(ToolsViewModel theViewModel)
        {
            InitializeComponent();
            DataContext = theViewModel;

            myVisualThreadedHelper = new VisualThreadedHelper();
        }

        private void OnLoadedToolsView(object theSender, RoutedEventArgs theE)
        {
            RecordTimer.Child = myVisualThreadedHelper.CreateThreadedLabelTimer();
        }

        private void OnStartRecording(object theSender, RoutedEventArgs theArgs)
        {
            myVisualThreadedHelper.StartTimer();
        }

        private void OnStopRecording(object theSender, RoutedEventArgs theArgs)
        {
            myVisualThreadedHelper.StopTimer();
        }
    }
}