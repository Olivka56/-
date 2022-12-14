# Итоговая проверочная работа

## Блок-схема

```mermaid
flowchart TD
    Start([Start])
    -->
    size_output[/Enter the size of the array/]
    -->
    size_input[/size/]
    -->
    array_create["string[] array = new string[size]"]
    -->
    array_output[/Enter the size of the array/]
    -->
    array_input[/array/]
    -->
    variables["
        int i = 0
        int resultSize = 0
    "]
    -->
    loop1{i < size}
    --Yes-->
    cond{"array[i].length <= 3"}-- Yes -->
    rspp[result_size++] -->ipp[i++]
    cond-- No ----> ipp[i++]
    ipp --> loop1
    loop1 -- No ------> array_create_2
    array_create_2["
        string[] resultArray = new string[resultSize]
        int resultIndex = 0
    "]
     -->
    loop2{i < size}
    --Yes-->
    cond2{"array[i].length <= 3"}-- Yes -->
    add_result["
        resultArray[resultIndex] = array[i]
        resultIndex++
    "] --> ipp2[i++]
    cond2--No--> ipp2[i++]
    ipp2 --> loop2
    loop2 --No------> End([End])
```
