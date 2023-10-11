// animation in the span on the first page
let spanTexts=document.getElementsByTagName("span");
        window.onload=function(){
            for(spanText of spanTexts){
                spanText.classList.add("active");
            }
        }

        // document.getElementById('searchInput').addEventListener('input', function () {
        //     console.log("Search input changed"); // Debugging statement
        
        //     var input, filter, tr, td, i, txtValue;
        //     input = document.getElementById('searchInput');
        //     filter = input.value.toUpperCase();
        //     tr = document.querySelectorAll('table tbody tr');
        
        //     for (i = 0; i < tr.length; i++) {
        //         td = tr[i].getElementsByTagName('td')[0];
        //         if (td) {
        //             txtValue = td.textContent || td.innerText;
        //             if (txtValue.toUpperCase().indexOf(filter) > -1) {
        //                 tr[i].style.display = ''; // Show rows that match the search
        //             } else {
        //                 tr[i].style.display = 'none'; // Hide rows that don't match
        //             }
        //         }
        //     }
        // });
        