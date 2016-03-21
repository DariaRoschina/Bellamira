<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="WebClient.HomePage" %>


<asp:Content runat="server" ID="Content1" ContentPlaceHolderID="MainContent">
    <h2><%: Title %>.</h2>
    

      <link type="text/css" rel="stylesheet" href="Content/rhinoslider-1.05.css" />
		<script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.7/jquery.min.js"></script>
		<script type="text/javascript" src="Scripts/rhinoslider-1.05.min.js"></script>
		<script type="text/javascript" src="Scripts/mousewheel.js"></script>
		<script type="text/javascript" src="Scripts/easing.js"></script>
		<script type="text/javascript">
			$(document).ready(function(){
				$('#slider').rhinoslider();
			});
		</script>
    <style type="text/css">
					
			#slider {
				width:600px;
				height:250px;
				
				/*IE bugfix*/
				padding:0;
				margin:0;
			}
			
			#slider li { list-style:none; }
			
			#page {
				width:600px;
				margin:50px auto;
			}
		</style>

    <div>
        <ul id="slider">
				<li><img src="img/slider/01.jpg" alt="" /></li>
				<li><img src="img/slider/02.jpg" alt="" /></li>
				<li><img src="img/slider/03.jpg" alt="" /></li>
				<li><img src="img/slider/04.jpg" alt="" /></li>
				<li><img src="img/slider/05.jpg" alt="" /></li>
			</ul>
    </div>
</asp:Content>