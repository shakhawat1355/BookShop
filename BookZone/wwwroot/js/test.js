$(document).ready(function () {
    $('#myButton').click(function () {
        var confirmation = confirm('@ViewBag.WarningMessage'); // Display the warning message using ViewBag

        if (confirmation) {
            // Proceed with the button click action
            // Add your desired logic here
        }
    });
});

<script src="https://code.jquery.com/jquery-3.6.0.min.js"></script>
