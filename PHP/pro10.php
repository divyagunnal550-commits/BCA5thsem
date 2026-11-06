<?php
$marks = array(85, 67, 92, 30, 45, 78, 28, 88, 34, 72);

$distinction = 0;
$failed = 0;

foreach($marks as $marks) {
  if($mark >= 75) {
     $distinction++; 
}else if($mark < 35){
    $failed++;
  }
}

echo"Number of Distinction Students: $distinction <br>";
echo"Number of failed Students: .$failed";
?>
