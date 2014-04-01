<!DOCTYPE html>
<html lang="en">

  <head>
    <meta charset='utf-8' />
    <meta http-equiv="X-UA-Compatible" content="chrome=1" />
    <meta name="description" content="Bootstrap-select : A custom select for @twitter bootstrap using button dropdown." />

    <link rel="stylesheet" type="text/css" media="screen" href="http://silviomoreto.github.io/bootstrap-select/stylesheets/stylesheet.css">
    <link href="http://netdna.bootstrapcdn.com/twitter-bootstrap/2.3.1/css/bootstrap-combined.min.css" rel="stylesheet">
    <link rel="stylesheet" type="text/css" media="screen" href="http://silviomoreto.github.io/bootstrap-select/stylesheets/bootstrap-select.css">
    <style type="text/css">
      .com { color: #93a1a1; }
      .lit { color: #195f91; }
      .pun, .opn, .clo { color: #93a1a1; }
      .fun { color: #dc322f; }
      .str, .atv { color: #D14; }
      .kwd, .prettyprint .tag { color: #1e347b; }
      .typ, .atn, .dec, .var { color: teal; }
      .pln { color: #48484c; }

      .prettyprint {
        padding: 8px;
        background-color: #f7f7f9;
        border: 1px solid #e1e1e8;
      }
      .prettyprint.linenums {
        -webkit-box-shadow: inset 40px 0 0 #fbfbfc, inset 41px 0 0 #ececf0;
           -moz-box-shadow: inset 40px 0 0 #fbfbfc, inset 41px 0 0 #ececf0;
                box-shadow: inset 40px 0 0 #fbfbfc, inset 41px 0 0 #ececf0;
      }

      /* Specify class=linenums on a pre to get line numbering */
      ol.linenums {
        margin: 0 0 0 33px; /* IE indents via margin-left */
      }
      ol.linenums li {
        padding-left: 12px;
        color: #bebec5;
        line-height: 20px;
        text-shadow: 0 1px 0 #fff;
      }
      .special {
        font-style: italic;
        font-weight: bold !important;
        color:#bc0000 !important;
        background:#000;
      }
    </style>

    <title>Crunching some pdfs</title>
  </head>

  <body>

    <!-- MAIN CONTENT -->
    <div id="main_content_wrap" class="outer">
      <section id="main_content" class="inner">
      	<form method="post" action="crunch.php">
        <h1>Any preferences?</h1>
        <hr>
        What would you like to eat? <select class="selectpicker" multiple data-selected-text-format="count">
        	<option>Exercise 1</option>
        	<option>Exercise 2</option>
        	<option>Exercise 3</option>
        	<option>Exercise 4</option>
        	<option>Exercise 5</option>
        </select>
        </hr>
        <a class="zip_download_link" href="#">Download files in a .zip file</a>
        <a class="tar_download_link" href="#">Download files in a .tar.gz file</a>
        </form>
	  </selection>
    </div>

    <!-- FOOTER  -->

    <script src="http://ajax.googleapis.com/ajax/libs/jquery/1.9.1/jquery.min.js"></script>
    <script src="http://netdna.bootstrapcdn.com/twitter-bootstrap/2.3.1/js/bootstrap.min.js"></script>
    <script src="http://silviomoreto.github.io/bootstrap-select/javascripts/bootstrap-select.js"></script>
    <script type="text/javascript">
      window.onload=function(){
      $('.selectpicker').selectpicker();
      };
    </script>
  </body>
</html>

