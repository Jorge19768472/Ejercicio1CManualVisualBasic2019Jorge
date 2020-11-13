Module Module1
    ' Ejercio iva codigo de discoduroderoer
    Sub Main()
        Const IVA As Double = 0.21

        Console.WriteLine("Escribe el valor del producto") ' muestra por pantalla lo que va perir en la sigiente

        Dim producto As Double = Console.ReadLine ' define una variable como numerico que acepta comas y lueho la
        'la asocia a un comando que recoge la infomacion por pantalla
        ' Las difucacion relaizadas con el progrma original de disco duro de roer son los parantesis que el desarollador 
        ' no lo contemplaba

        Console.WriteLine("EL IVA  de producto es: " & (producto * IVA) & " euros, el valor final es " & (producto + (producto * IVA)) & " euros ") 'Nos da cuanto es el iva y luego el producto con el iva
        ' Hay un parectis más `por sugenecia del Visual studio 2019

        Console.ReadKey() ' espera nutra accion el progrmador sugeririo readline en vez readkey 



    End Sub

End Module
