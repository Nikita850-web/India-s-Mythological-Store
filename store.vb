<!DOCTYPE html>
<html>
<head>
<meta name="viewport" content="width=device-width, initial-scale=1">
<style>

.topnav {
  overflow: hidden;
  background-color: #333;
}

.topnav a {
  float: left;
  color: #f2f2f2;
  text-align: center;
  padding: 14px 16px;
  text-decoration: none;
  font-size: 17px;
}

.topnav a:hover {
  background-color: #ddd;
  color: black;
}

.topnav a.active {
  background-color: #04AA6D;
  color: white;

}
.container {
  position: relative;
  text-align: center;
  color: white;
}
.centered {
  position: absolute;
  top: 50%;
  left: 50%;
  transform: translate(-50%, -50%);
  color: #333;
}
.bs{
  color: #ddd;
  background-color: black;
}
{
  box-sizing: border-box;
}

/* Float four columns side by side */
.column {
  float: left;
  width: 25%;
  padding: 0 10px;
}

/* Remove extra left and right margins, due to padding */
.row {margin: 0 -3px;}

/* Clear floats after the columns */
.row:after {
  content: "";
  display: table;
  clear: both;
}

/* Responsive columns */
@media screen and (max-width: 600px) {
  .column {
    width: 100%;
    display: block;
    margin-bottom: 20px;
  }
}

/* Style the counter cards */
.card {
  box-shadow: 0 4px 8px 0 rgba(0, 0, 0, 0.2);
  padding: 16px;
  text-align: center;
  background-color: #f1f1f1;
}

</style>
</head>
<body>
<div class="topnav">
  <a class="active" href="#home"><H1>HOME</H1></a>
  <a href="#news"><h1>BEST SELLING</h1></a>
  <a href="#contact"><H1>RECOMMENDATION></H1></a>
  <a href="#about"><H1>ABOUT</H1></a>
</div>
<div class="container">
  <img src="https://ychef.files.bbci.co.uk/976x549/p07m8fp3.jpg" alt="Snow" style="width:90%;">
  <div class="centered"><h1>INDIA'S MYTHOLOGICAL STORE</h1><br><h2>Indian Mythology: Tales, Symbols, and Rituals from the Heart of the Subcontinent An exploration of 99 classic myths of India from an entirely non-Western paradigm that provides a fresh understanding of the Hindu spiritual landscape. Compares and contrasts Indian mythology with the stories of the Bible, ancient Egypt, Greece, Scandinavia, and Mesopotamia. Looks at the evolution of Indian narratives and their interpretations over the millennia</h2></div>
</div>
  <div class="bs"><h1> BEST SELLING</h1></div>
<div class="row">
  <div class="column">
    <div class="card">
      <img src="https://miro.medium.com/max/648/1*6tRFV9ShjJnfJQrgi9UR7g.jpeg">
      <p>Some text</p>
      <p>Some text</p>
    </div>
  </div>

  <div class="column">
    <div class="card">
      <img src="https://booksom.com/wp-content/uploads/2018/09/ram-scion-of-ikshvaku-amish-tripathi.jpg">
      <p>Some text</p>
      <p>Some text</p>
    </div>
  </div>
  
  <div class="column">
    <div class="card">
      <img src="https://cdn.shortpixel.ai/spai/w_824+q_lossless+ret_img+to_webp/https://dreamsandmythology.com/wp-content/uploads/2020/02/Karnas-Wife.jpg">
      <p>Some text</p>
      <p>Some text</p>
    </div>
  </div>
</div>
</body>


  
</html>
