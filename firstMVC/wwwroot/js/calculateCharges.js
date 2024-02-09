﻿$(document).ready(function () {
    $('#calculateButton').click(function () {
        var numberOfPictures = $('#numberOfPictures').val();
        var chargePerPicture = $('#chargePerPicture').val();

        // Validate input
        if (numberOfPictures <= 0 || isNaN(numberOfPictures)) {
            alert('Please enter a positive number of pictures.');
            return;
        }

        // Calculate total
        var totalCharge = numberOfPictures * chargePerPicture;
        $('#totalCharge').val(totalCharge);
    });
});
