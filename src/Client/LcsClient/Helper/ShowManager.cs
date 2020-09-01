using DevExpress.XtraBars.Docking;
using DevExpress.XtraBars.Docking2010;
using DevExpress.XtraBars.Docking2010.Views.Tabbed;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LcsClient
{
    public class ShowManager
    {
        public static readonly ShowManager It = new ShowManager();

        private ShowManager()
        {

        }

        private DocumentManager _documentManager;
        private TabbedView _tabbedView;
        private DockManager _dockManager;

        public void Init(DocumentManager documentManager, TabbedView tabbedView, DockManager dockManager)
        {
            this._documentManager = documentManager;
            this._tabbedView = tabbedView;
            this._dockManager = dockManager;
        }

        public void Show(string caption, DockingStyle dockingStyle, Func<UserControl> getUserControl)
        {
            Show(caption, caption, dockingStyle, getUserControl);
        }

        public void Show(string name, string caption, DockingStyle dockingStyle, Func<UserControl> getUserControl)
        {
            switch (dockingStyle)
            {
                case DockingStyle.Left:
                case DockingStyle.Right:
                case DockingStyle.Top:
                case DockingStyle.Bottom:
                    var dockPanel = _dockManager.Panels.FirstOrDefault(m => m.Name == name);
                    if (dockPanel != null)
                    {
                        dockPanel.Visibility = DockVisibility.Visible;
                    }
                    else
                    {
                        var pnlContainer = _dockManager.Panels.FirstOrDefault(m => m.Dock == dockingStyle);
                        if (pnlContainer == null)
                        {
                            dockPanel = _dockManager.AddPanel(dockingStyle);
                        }
                        else
                        {
                            dockPanel = pnlContainer.AddPanel();
                            dockPanel.ParentPanel.Tabbed = true;
                        }
                        dockPanel.Text = caption;
                        dockPanel.Name = name;
                        var ctrl = getUserControl();
                        ctrl.Dock = DockStyle.Fill;
                        dockPanel.Size = ctrl.Size;
                        dockPanel.ControlContainer.Controls.Add(ctrl);
                    }
                    _dockManager.ActivePanel = dockPanel;
                    break;
                case DockingStyle.Fill:
                    var document = _tabbedView.Documents.FindFirst(m => m.Control.Name == name);
                    if (document == null)
                    {
                        var ctrl = getUserControl();
                        ctrl.Name = name;
                        ctrl.Dock = DockStyle.Fill;
                        document = _tabbedView.AddDocument(ctrl);
                        document.Caption = caption;
                    }
                    _tabbedView.Controller.Activate(document);
                    break;
                default:
                    throw new NotSupportedException();
            }
        }

        public void Close(string Name)
        {
            var dockPanel = _dockManager.Panels.FirstOrDefault(m => m.Name == Name);
            if (dockPanel != null)
            {
                dockPanel.Close();
            }
            var document = _tabbedView.Documents.FindFirst(m=>m.Control!=null&&m.Control.Name==Name);
            if(document!=null)
            {
                _tabbedView.Controller.Close(document);
            }
        }
    }
}
