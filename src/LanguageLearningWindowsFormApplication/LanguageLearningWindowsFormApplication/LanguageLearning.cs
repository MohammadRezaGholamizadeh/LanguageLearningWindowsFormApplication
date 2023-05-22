using Microsoft.Web.WebView2.Core;
using Microsoft.Web.WebView2.WinForms;

namespace LanguageLearningWindowsFormApplication
{
    public partial class LanguageLearning : Form
    {
        private WebView2 webView;

        public LanguageLearning()
        {
            InitializeComponent();
            InitializeWebView();
            this.FormBorderStyle = FormBorderStyle.Sizable;
        }

        private async void InitializeWebView()
        {
            webView = new WebView2();
            webView.Dock = DockStyle.Fill;
            webView.NavigationStarting +=
                WebView_NavigationStarting;
            webView.NavigationCompleted +=
                WebView_NavigationCompleted;
            webView.CoreWebView2InitializationCompleted +=
                WebView_CoreWebView2InitializationCompleted;
            Controls.Add(webView);

            await webView.EnsureCoreWebView2Async();
        }
        private void WebView_CoreWebView2InitializationCompleted(
            object sender,
            CoreWebView2InitializationCompletedEventArgs e)
        {
            if (e.IsSuccess)
            {
                webView.CoreWebView2.Settings.AreDefaultScriptDialogsEnabled = false;
                btn_backButton.Enabled = webView.CanGoBack;
                btn_forwardButton.Enabled = webView.CanGoForward;

                string css = @"
                    ::-webkit-scrollbar {
                        width: 0 !important;
                        height: 0 !important;
                    }
                ";
                webView.CoreWebView2.AddScriptToExecuteOnDocumentCreatedAsync(css);

            }
        }
        private void WebView_NavigationStarting(
            object sender,
            CoreWebView2NavigationStartingEventArgs e)
        {
            webView.CoreWebView2.Settings.IsStatusBarEnabled = false;
        }

        private void WebView_NavigationCompleted(
            object sender,
            CoreWebView2NavigationCompletedEventArgs e)
        {
            btn_backButton.Enabled = webView.CanGoBack;
            btn_forwardButton.Enabled = webView.CanGoForward;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            webView.Source = new Uri("https://www.javadmirzaei.ir");
        }

        private void btn_backButton_Click(object sender, EventArgs e)
        {
            if (webView.CanGoBack)
                webView.GoBack();
        }

        private void btn_forwardButton_Click(object sender, EventArgs e)
        {
            if (webView.CanGoForward)
                webView.GoForward();
        }

        private void btn_reloadButton_Click(object sender, EventArgs e)
        {
            webView.Reload();
        }
    }
}
