<!DOCTYPE html>
<html>
<head>
  <title>Arithmetic Operations</title>
  <style>
    *{
      scroll-behavior: smooth;
      align-item:center;
    }
     /* CSS para sa  Navigation Bar */
    nav {
      background-color: #333;
      height: 50px;
      display: flex;
      justify-content:center;
      alig-items:center;
      position: fixed;
      top: 0;
      left: 0;
      width: 100%;
      z-index: 9999;
      float: right;
    }
    img{
      width: 50px;
      margin-right: 10px;
    }

    nav ul {
      list-style-type: none;
      margin: 0;
      padding: 0;
      display: flex;
      align-items: center;
      height: 100%;
    }
    
    nav li {
      margin-right: 20px;
    }
    
    nav a {
      color: #fff;
      text-decoration: none;
      font-size: 18px;
      padding: 10px;
    }
    nav a:hover {
      background-color: #555;
    }
    h1{
      text-align:center;
      padding-top:100px;
    }
    p{
      text-align:center;
      font-size:20px;
      font-weight: bold;
    }
    h2{
      text-align:center;
      text-decoration:underline;
      font-size:20px;
      margin:0px;
    } 
    .mcdo{
      height:300px;
      width:400px;
      margin:auto;
      margin-left: 25px;
      margin-bottom:150px;
    }
    .section{
      height: 550px;
      text-align:center;
    }
    .container{
      display:flex;
      align-items:flex-start;
      border: 2px solid black;
      height:550px;
      max-width:1300px;
      margin: 70px auto auto auto;
    }
      /* CSS para sa  form */
    form {
      margin: auto;
      padding: 20px;
      background-color: darkcyan;
      border-radius: 10px;
      border: 2px solid black;
    }
    /* CSS para sa  label*/
    label {
      display: block;
      margin-bottom: 5px;
      margin-left:13px;
      font-weight: bold;
      text-align:left;
    }
    /* CSS para sa  input ni user*/
    input[type="number"], input[type="submit"] {
      width: 80%;
      padding: 8px 10px;
      margin-bottom: 10px;
      margin-left:13px;
      border: 2px solid black;
      border-radius: 3px;
    }
    input[type="submit"] {
      background-color: #3b5998;
      display: block;
      margin-bottom: 5px;
      margin-left:13px;
      font-weight: bold;
      color: white;
      cursor: pointer;
    }
    /* CSS para sa  output */
    #output {
      margin: auto;
      background-color: #e8e8e8;
      border-radius: 10px;
      text-align:LEFT;
      width: 350px;
      font-size: 20px;
      border: 2px solid black;
    }
     /* CSS naman para sa mga para sa  Output results */
    .output span {
      font-weight: bold;
    }
    /* CSS para sa payslip at payslip table */
    .payslip {
      margin:auto;
      display: flex;
      flex-direction:column;
      align-items: center;
    }
    .payslip table {
      width: 400px;
      border-collapse: collapse;
      margin: auto;
    }
    
    .payslip th,.payslip td {
      padding: 8px;
      border: 1px solid black;
      text-align: left;
    }
    .payslip th {
      background-color: #333;
      color: white;
      text-align: center;
    }
  </style>
</head>
<!-- PARA SA NAVIGATION BAR -->
  <nav>
    <ul>
      <li><img src="https://www.tailorbrands.com/wp-content/uploads/2020/07/mcdonalds-logo.jpg" alt="logo"></li>
      <li><a href="Dela%20Cruz,%20Jhon%20Angelo.php">Home</a></li>
      <li><a href="https://doh.gov.ph/2019-nCoV" target="_blank" >About</a></li>
      <li><a href="https://www.dti.gov.ph/" target="_blank">Services</a></li>
      <li><a href="https://www.dpwh.gov.ph/" target="_blank">Contact</a></li>
      <li><a href="#Payroll">Payroll System</a></li>
    </ul>
  </nav>
  <section class="section">
    <h1>City of Malabon University</h1>
    <p>NAME: DELA CRUZ, JHON ANGELO</p>
    <img class="mcdo" src="https://www.siouxfalls.business/wp-content/uploads/2022/10/mcdonalds-exterior.jpg" alt="img">
    <img class="mcdo" src="https://sgp1.digitaloceanspaces.com/tz-mag-ph/wp-content/uploads/2023/01/050501014646/McDonalds-Featured-Photo.jpg" alt="img">
    <img class="mcdo" src="https://www.bworldonline.com/wp-content/uploads/2022/06/McDonalds-new-store-in-Hermosa-Bataan.png" alt="img">
  </section>
  <section class="section" id="Payroll">
    <div class="container">
    <h2>Payroll System</h2>
    <!-- HTML form for user input -->
    <form method="POST" action="">

    <label for="sahod">RATE PER DAY:</label>
    <input type="number" name="sahod"><br>

    <label for="days">DAY/S:</label>
    <input type="number" name="days"><br><br>
    <hr></hr>
    <label for="SSS">SSS:</label>
    <input type="number" name="SSS"><br>

    <label for="TAX">TAX:</label>
    <input type="number" name="TAX"><br>

    <label for="PAG_IBIG">PAG_IBIG:</label>
    <input type="number" name="PAG_IBIG"><br>

    <input type="submit" value="Calculate">
  </form>
<?php
  if ($_SERVER['REQUEST_METHOD'] === 'POST') {
  // Get user input
  $sahod = $_POST  ['sahod'];
  $days = $_POST  ['days'];

  $SSS = $_POST  ['SSS'];
  $TAX = $_POST  ['TAX'];
  $PAG_IBIG = $_POST  ['PAG_IBIG'];

  // Perform arithmetic operations
  $STOTAL_PAY = $sahod * $days;
  $Deduction =  $SSS + $TAX + $PAG_IBIG;
  $T_home = $STOTAL_PAY - $Deduction;
  // Output results
  
  echo '<div id="output">';
  // span ay parang div lang. Ang iba lang sakanya ilalagay siya para maging conatiner ng mga text, para ma-design mo siya sa css ng hindi na ginagamit si div.
    echo "<span>TOTAL:</span> $STOTAL_PAY<br>"; 
    echo "<hr>";
    echo "<span>SSS:</span> $SSS<br>";
    echo "<span>TAX:</span> $TAX<br>"; 
    echo "<span>PAG-IBIG:</span> $PAG_IBIG<br>";
    echo "<hr>";
    echo "<span>TOTAL DEDUCTION:</span> $Deduction<br>";
    echo "<hr>";
    echo "<span>TAKE HOME PAY IS:</span> $T_home<br>";
  echo '</div>';
  
  // Generate Payslip
  echo '<div class="payslip">';
    echo '<table>';
    echo '<tr><th colspan="2">Payslip</th></tr>';
    echo '<tr><td>Total Earnings</td><td>'.$STOTAL_PAY.'</td></tr>';
    echo '<tr><td>Total Deductions</td><td>'.$Deduction.'</td></tr>';
    echo '<tr><td>Net Pay</td><td>'.$T_home.'</td></tr>';
    echo '<tr><th colspan="2"></th></tr>';
    echo '</table>';
  echo '</div>';
  }
?>
</section>
</div>
</body>
</html>