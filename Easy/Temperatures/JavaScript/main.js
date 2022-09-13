let n = parseInt(readline()); // the number of temperatures to analyse
let temps = readline(); // the n temperatures expressed as integers ranging from -273 to 5526

// Write an action using print()
// To debug: printErr('Debug messages...');

if (temps) {

    let tempArray = temps.split(' ');

    let min = tempArray[0];

    for(let i = 1; i< tempArray.length; i++){
        
        if (Math.abs(min) > Math.abs(tempArray[i])) {
            min = tempArray[i];
        }else if(Math.abs(min) == Math.abs(tempArray[i]) && min < tempArray[i]){
            min = tempArray[i];
        }

    }

    console.log(min);

}else{
    console.log(0);
}