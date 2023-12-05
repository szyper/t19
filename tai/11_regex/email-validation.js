       //pobieramy elementy HTML
       let emailInput = document.getElementById("email_input");
       let submitButton = document.getElementById("submit_button");
       let resultText = document.getElementById("result_text");

       //dodajemy funkcję obsługi zdarzeń do przycisków
       submitButton.addEventListener("click", function(event){
        //zapobiegamy domyślnej akcji przycisku
        event.preventDefault();

         //pobieramy wartość pola adresu e-mail
         let emailValue = emailInput.value;
         //console.log(emailValue);

         let emailValueTrimmed = emailValue.trim(); 

         //sprawdź czy pole adresu e-mail nie jest puste
         if (emailValueTrimmed === ""){
            //wyświetlamy komunikat o błędzie
            resultText.textContent = "Adres e-mail jest pusty";
            resultText.style.color = "red";
         }else{
            //sprawdzamy czy adres e-mail jest poprawny za pomocą wyrażenia regularnego
            let emailRegex = /^[a-zA-Z0-9._-]+@[a-zA-Z0-9._-]+\.[a-zA-Z]{2,4}$/;
            let emailValid = emailRegex.test(emailValueTrimmed);
            //console.log(emailValid);

            //wyświatlamy komunikat o wyniku walidacji
            if (emailValid){
                resultText.textContent = "Adres e-mail jest poprawny";
                resultText.style.color = "green";
            }else{
                resultText.textContent = "Adres e-mail jest niepoprawny";
                resultText.style.color = "red";
            }
         }

       });