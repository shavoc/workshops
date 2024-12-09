<?php
if ($_SERVER["REQUEST_METHOD"] == "POST") {
    $userInput = $_POST['userInput']; 
    echo "<h3>Hi, " . $userInput . "!</h3>";
} else {
    echo '<form method="POST">
            Enter your name: <input type="text" name="userInput">
            <button type="submit">Submit</button>
          </form>';
}
?>
