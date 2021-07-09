function TerribleSort(nums :number[])
{
    nums.forEach(element => {
        setTimeout( () => console.log(element), element);
    });
}
    