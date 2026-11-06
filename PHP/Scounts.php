<?php
$age = 15;

if ($age >= 10 && $age <= 12)
{
   echo "Scout is assigned to Tent A";
}
elseif($age >= 13 && $age <=15)
{
   echo "Sout is assigned to Tent B";
}
elseif($age >= 16 && $age <= 18)
{
     echo "Scout is assigned to Tent c";
}
else
{
    echo "Scout is not eligible for any tent";
}
?>