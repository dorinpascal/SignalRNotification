#pragma checksum "C:\Users\User\RiderProjects\SignalRNotification\SignalRNotification\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "386c0f5ff1d33e0d8a4ac86f56e805ba3542c8ea"
// <auto-generated/>
#pragma warning disable 1591
namespace SignalRNotification.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\User\RiderProjects\SignalRNotification\SignalRNotification\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\RiderProjects\SignalRNotification\SignalRNotification\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\User\RiderProjects\SignalRNotification\SignalRNotification\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\User\RiderProjects\SignalRNotification\SignalRNotification\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\User\RiderProjects\SignalRNotification\SignalRNotification\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\User\RiderProjects\SignalRNotification\SignalRNotification\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\User\RiderProjects\SignalRNotification\SignalRNotification\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\User\RiderProjects\SignalRNotification\SignalRNotification\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\User\RiderProjects\SignalRNotification\SignalRNotification\_Imports.razor"
using SignalRNotification;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\User\RiderProjects\SignalRNotification\SignalRNotification\_Imports.razor"
using SignalRNotification.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\RiderProjects\SignalRNotification\SignalRNotification\Pages\Index.razor"
using Microsoft.AspNetCore.SignalR.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\User\RiderProjects\SignalRNotification\SignalRNotification\Pages\Index.razor"
using SignalRNotification.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "id", "noti_container");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "notification_counter");
            __builder.AddContent(4, 
#nullable restore
#line 7 "C:\Users\User\RiderProjects\SignalRNotification\SignalRNotification\Pages\Index.razor"
                                       currentUserMgsList.Count

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n    ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "notification_button");
            __builder.AddAttribute(8, "style", "background: #2e467c;");
            __builder.AddAttribute(9, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 8 "C:\Users\User\RiderProjects\SignalRNotification\SignalRNotification\Pages\Index.razor"
                                                                            NotificationHideShow

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n    ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "notification");
            __builder.AddAttribute(13, "style", "display:" + " " + (
#nullable restore
#line 9 "C:\Users\User\RiderProjects\SignalRNotification\SignalRNotification\Pages\Index.razor"
                                               BoxCss

#line default
#line hidden
#nullable disable
            ) + " !important");
            __builder.AddAttribute(14, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 9 "C:\Users\User\RiderProjects\SignalRNotification\SignalRNotification\Pages\Index.razor"
                                                                            NotificationHideShow

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenElement(15, "h3");
            __builder.AddContent(16, "Notifications (");
            __builder.OpenElement(17, "span");
            __builder.AddAttribute(18, "class", "notiCounterOnHead");
            __builder.AddContent(19, 
#nullable restore
#line 10 "C:\Users\User\RiderProjects\SignalRNotification\SignalRNotification\Pages\Index.razor"
                                                             currentUserMgsList.Count

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddContent(20, ")");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n        \r\n        ");
            __builder.OpenElement(22, "div");
            __builder.AddAttribute(23, "class", "notificationItems");
#nullable restore
#line 14 "C:\Users\User\RiderProjects\SignalRNotification\SignalRNotification\Pages\Index.razor"
             foreach (var nmObj in currentUserMgsList)
            { 

#line default
#line hidden
#nullable disable
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "class", "singleNotiDiv");
            __builder.AddAttribute(26, "notiId", 
#nullable restore
#line 16 "C:\Users\User\RiderProjects\SignalRNotification\SignalRNotification\Pages\Index.razor"
                                                    nmObj.MsgId

#line default
#line hidden
#nullable disable
            );
            __builder.OpenElement(27, "h4");
            __builder.AddAttribute(28, "class", "notiFromPropName");
            __builder.AddContent(29, "Sender : ");
            __builder.AddContent(30, 
#nullable restore
#line 17 "C:\Users\User\RiderProjects\SignalRNotification\SignalRNotification\Pages\Index.razor"
                                                           nmObj.SenderName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n                    ");
            __builder.OpenElement(32, "h4");
            __builder.AddAttribute(33, "class", "notificationtTitle");
            __builder.OpenElement(34, "b");
            __builder.AddContent(35, "Title : ");
            __builder.AddContent(36, 
#nullable restore
#line 18 "C:\Users\User\RiderProjects\SignalRNotification\SignalRNotification\Pages\Index.razor"
                                                               nmObj.MsgTitle

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n                    ");
            __builder.OpenElement(38, "div");
            __builder.AddAttribute(39, "class", "notificationBody");
            __builder.AddContent(40, " Message: ");
            __builder.AddContent(41, 
#nullable restore
#line 19 "C:\Users\User\RiderProjects\SignalRNotification\SignalRNotification\Pages\Index.razor"
                                                             nmObj.MsgBody

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n                    ");
            __builder.OpenElement(43, "div");
            __builder.AddAttribute(44, "class", "notiCreatedDate");
            __builder.AddContent(45, "Date: ");
            __builder.AddContent(46, 
#nullable restore
#line 20 "C:\Users\User\RiderProjects\SignalRNotification\SignalRNotification\Pages\Index.razor"
                                                        nmObj.MsgDateSt

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 22 "C:\Users\User\RiderProjects\SignalRNotification\SignalRNotification\Pages\Index.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n        ");
            __builder.AddMarkupContent(48, "<div class=\"SeeAll\"><a href=\"#\">See All</a></div>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n\r\n\r\n\r\n\r\n\r\n<br>\r\n<br>\r\nSender Name :\r\n");
            __builder.OpenElement(50, "input");
            __builder.AddAttribute(51, "type", "text");
            __builder.AddAttribute(52, "class", "form-control");
            __builder.AddAttribute(53, "placeholder", "Sender Name");
            __builder.AddAttribute(54, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 39 "C:\Users\User\RiderProjects\SignalRNotification\SignalRNotification\Pages\Index.razor"
                                               notification.SenderName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(55, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => notification.SenderName = __value, notification.SenderName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\nReceiver Name :\r\n");
            __builder.OpenElement(57, "input");
            __builder.AddAttribute(58, "type", "text");
            __builder.AddAttribute(59, "class", "form-control");
            __builder.AddAttribute(60, "placeholder", "Receiver Name");
            __builder.AddAttribute(61, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 41 "C:\Users\User\RiderProjects\SignalRNotification\SignalRNotification\Pages\Index.razor"
                                               notification.ReciverName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(62, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => notification.ReciverName = __value, notification.ReciverName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\r\nMessage :\r\n");
            __builder.OpenElement(64, "input");
            __builder.AddAttribute(65, "type", "text");
            __builder.AddAttribute(66, "class", "form-control");
            __builder.AddAttribute(67, "placeholder", "Title");
            __builder.AddAttribute(68, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 43 "C:\Users\User\RiderProjects\SignalRNotification\SignalRNotification\Pages\Index.razor"
                                               notification.MsgTitle

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(69, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => notification.MsgTitle = __value, notification.MsgTitle));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\r\n<br>\r\n");
            __builder.OpenElement(71, "input");
            __builder.AddAttribute(72, "type", "text");
            __builder.AddAttribute(73, "class", "form-control");
            __builder.AddAttribute(74, "placeholder", "Body");
            __builder.AddAttribute(75, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 45 "C:\Users\User\RiderProjects\SignalRNotification\SignalRNotification\Pages\Index.razor"
                                               notification.MsgBody

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(76, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => notification.MsgBody = __value, notification.MsgBody));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(77, "   \r\n<br>\r\n<br>\r\n");
            __builder.OpenElement(78, "button");
            __builder.AddAttribute(79, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 48 "C:\Users\User\RiderProjects\SignalRNotification\SignalRNotification\Pages\Index.razor"
                  Send

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(80, "disabled", 
#nullable restore
#line 48 "C:\Users\User\RiderProjects\SignalRNotification\SignalRNotification\Pages\Index.razor"
                                    !IsConnected

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(81, "Send");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 52 "C:\Users\User\RiderProjects\SignalRNotification\SignalRNotification\Pages\Index.razor"
       

    private List<Notification> allNotificationMsg = new List<Notification>();
    private List<Notification> currentUserMgsList = new List<Notification>();
    private Notification notification = new Notification();

    private HubConnection hubConnection;
    private string BoxCss = "none";

    protected override async Task OnInitializedAsync()
    {
        hubConnection = new HubConnectionBuilder().WithUrl(NavigationManager.ToAbsoluteUri("/chatHub")).Build();

        hubConnection.On<string, string, string, string>("ReceiveMessage", (senderName, receiverName, title, message) =>
        {
            allNotificationMsg.Add(new Notification()
            {
                MsgId = allNotificationMsg.Count() + 1,
                SenderName = senderName,
                ReciverName = receiverName,
                MsgTitle = title,
                MsgBody = message
            });

            currentUserMgsList = allNotificationMsg.Where(x => x.SenderName != notification.SenderName).ToList();
            StateHasChanged();
        });
        await hubConnection.StartAsync();
    }


    private async Task Send()
    {
        await hubConnection.SendAsync("sendMessage", notification.SenderName, notification.ReciverName, notification.MsgTitle, notification.MsgBody);
        notification.MsgTitle = "";
        notification.MsgBody = "";
    }

    private async Task aleo()
    {
        Console.WriteLine("Aleo");
    }

    public bool IsConnected => hubConnection.State == HubConnectionState.Connected;

    private void NotificationHideShow()
    {
        if (BoxCss == "none") BoxCss = "block";
        else BoxCss = "none";

    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591