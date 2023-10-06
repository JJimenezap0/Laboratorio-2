Imports System.ComponentModel.Design

Module Module1

    Sub Main()

        Caja()
        Console.Read()

    End Sub

    Sub Caja()

        'Codigo hecho por Juan Jose Jimenez Aparicio Cod estudiante: ja0577012021 '


        Console.BackgroundColor = ConsoleColor.White
        Console.Clear()

        Console.ForegroundColor = ConsoleColor.Black
        Console.WriteLine("Bienvenido a su tienda de celulares de confianza")
        Console.WriteLine()
        Console.WriteLine("Bienvenido a Electronica Jimenez")
        Console.WriteLine("-----------------------------------------------------------------------------------------")
        Console.WriteLine()
        Console.WriteLine("Observe nuestro catalogo de telefonos inteligentes, junto a cada modelo encontrara el precio respectivo de cada celular")
        Console.WriteLine("1. Samsung Galaxy S20 - $255")
        Console.WriteLine("2. Samsung Galaxy S21 - $280")
        Console.WriteLine("3. Samsung Galaxy S22 - $350")
        Console.WriteLine("4. Iphone 13 pro max - $625")
        Console.WriteLine("5. Iphone 14 pro max - $990")


        'Al iniciar declaramos las variables que posteriormente utilizaremos para el desarrollo del ejecicio '

        Dim price1, price2, price3, price4, price5 As Double
        Dim total1, total2, total3, total4, total5, subtotal1, subtotal2, subtotal3, subtotal4, subtotal5, final As Double
        Dim extra1 As Double
        Dim cash, selec As String
        Dim more As Double

        Console.WriteLine()
        Console.WriteLine("-----------------------------------------------------------------------------------------")
        Console.WriteLine("Dijite su presupuesto total")
        cash = Console.ReadLine

        price1 = 255
        price2 = 280
        price3 = 350
        price4 = 625
        price5 = 990


        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine("Seleccione uno de nuestros productos para continuar con la compra")
        Console.WriteLine("Seleccione el producto que desea comprar (Articulo 1, 2 , ...")
        selec = Console.ReadLine
        Console.WriteLine("-----------------------------------------------------------------------------------------")

        total1 = cash - price1
        total2 = cash - price2
        total3 = cash - price3
        total4 = cash - price4
        total5 = cash - price5

        subtotal1 = total1 * -1

        ' Apartir de este punto comienza la estructuracion de un codigo que pueda calular cada punto ' 
        ' de la compra de un producto y las variables que esta compra pueda presentar ' 

        If selec = 1 Then
            Console.WriteLine("A saleccionado Samsung Galaxy S20 - $255")
            If total1 = 0 Then
                Console.WriteLine("Muchas gracias por su compra, vuelva pronto")
            ElseIf total1 > 0 Then
                Console.WriteLine("Muchas gracias por su compra, su cambio es de $" & total1)
            ElseIf total1 < 0 Then
                Console.WriteLine("Lo sentimos, su presupuesto es insuficiente para compar el articulo")
                Console.WriteLine("Falta un total de $" & subtotal1)
                Console.WriteLine("¿Desea agregar mas dinaro al presupuesto? (1)para continuar o (2)para finalizar")
                more = Console.ReadLine
                Console.WriteLine("------------------------------------------------------------------------------------------")
                Console.WriteLine()

                If more = 1 Then
                    Console.WriteLine("Monto a agregar")
                    Console.WriteLine("Dijite el monto extra")
                    extra1 = Console.ReadLine
                    final = extra1 - subtotal1
                    If final = 0 Then
                        Console.WriteLine("Muchas gracias por su compra, vuelva pronto")
                    ElseIf final > 0 Then
                        Console.WriteLine("Muchas gracias por su compra, su cambio es de $" & final)

                    End If

                End If
                If more = 2 Then
                    Console.Clear()
                    Console.WriteLine("Gracias por vicitar nuestra tienda")
                End If
            End If
        End If


        'Espacio entre codigo para el calculo de cada producto '

        subtotal2 = total2 * -1

        If selec = 2 Then
            Console.WriteLine("A seleccionado Samsung Galaxy S21 - $280")
            If total2 = 0 Then
                Console.WriteLine("Muchas gracias por su compra, vuelva pronto")
            ElseIf total2 > 0 Then
                Console.WriteLine("Muchas gracias por su compra, su cambio es de $" & total2)
            ElseIf total2 < 0 Then
                Console.WriteLine("Lo sentimos, su presupuesto es insuficiente para compar el articulo")
                Console.WriteLine("Falta un total de $" & subtotal2)
                Console.WriteLine("¿Desea agregar mas dinaro al presupuesto? (1)para continuar o (2)para finalizar")
                more = Console.ReadLine
                Console.WriteLine("------------------------------------------------------------------------------------------")
                Console.WriteLine()

                If more = 1 Then
                    Console.WriteLine("Monto a agregar")
                    Console.WriteLine("Dijite el monto extra")
                    extra1 = Console.ReadLine
                    final = extra1 - subtotal2
                    If final = 0 Then
                        Console.WriteLine("Muchas gracias por su compra, vuelva pronto")
                    ElseIf final > 0 Then
                        Console.WriteLine("Muchas gracias por su compra, su cambio es de $" & final)

                    End If

                End If
                If more = 2 Then
                    Console.Clear()
                    Console.WriteLine("Gracias por vicitar nuestra tienda")
                End If
            End If
        End If


        'Espacio entre codigo para el calculo de cada producto '

        subtotal3 = total3 * -1

        If selec = 3 Then
            Console.WriteLine("A seleccionado Samsung Galaxy S22 - $350")
            If total3 = 0 Then
                Console.WriteLine("Muchas gracias por su compra, vuelva pronto")
            ElseIf total3 > 0 Then
                Console.WriteLine("Muchas gracias por su compra, su cambio es de $" & total3)
            ElseIf total3 < 0 Then
                Console.WriteLine("Lo sentimos, su presupuesto es insuficiente para compar el articulo")
                Console.WriteLine("Falta un total de $" & subtotal3)
                Console.WriteLine("¿Desea agregar mas dinaro al presupuesto? (1)para continuar o (2)para finalizar")
                more = Console.ReadLine
                Console.WriteLine("------------------------------------------------------------------------------------------")
                Console.WriteLine()

                If more = 1 Then
                    Console.WriteLine("Monto a agregar")
                    Console.WriteLine("Dijite el monto extra")
                    extra1 = Console.ReadLine
                    final = extra1 - subtotal3
                    If final = 0 Then
                        Console.WriteLine("Muchas gracias por su compra, vuelva pronto")
                    ElseIf final > 0 Then
                        Console.WriteLine("Muchas gracias por su compra, su cambio es de $" & final)

                    End If

                End If
                If more = 2 Then
                    Console.Clear()
                    Console.WriteLine("Gracias por vicitar nuestra tienda")
                End If
            End If
        End If

        'Espacio entre codigo para el calculo de cada producto '

        subtotal4 = total4 * -1

        If selec = 4 Then
            Console.WriteLine("A seleccionado Iphone 13 pro max - $625")
            If total4 = 0 Then
                Console.WriteLine("Muchas gracias por su compra, vuelva pronto")
            ElseIf total4 > 0 Then
                Console.WriteLine("Muchas gracias por su compra, su cambio es de $" & total4)
            ElseIf total4 < 0 Then
                Console.WriteLine("Lo sentimos, su presupuesto es insuficiente para compar el articulo")
                Console.WriteLine("Falta un total de $" & subtotal4)
                Console.WriteLine("¿Desea agregar mas dinaro al presupuesto? (1)para continuar o (2)para finalizar")
                more = Console.ReadLine
                Console.WriteLine("------------------------------------------------------------------------------------------")
                Console.WriteLine()

                If more = 1 Then
                    Console.WriteLine("Monto a agregar")
                    Console.WriteLine("Dijite el monto extra")
                    extra1 = Console.ReadLine
                    final = extra1 - subtotal4
                    If final = 0 Then
                        Console.WriteLine("Muchas gracias por su compra, vuelva pronto")
                    ElseIf final > 0 Then
                        Console.WriteLine("Muchas gracias por su compra, su cambio es de $" & final)

                    End If

                End If
                If more = 2 Then
                    Console.Clear()
                    Console.WriteLine("Gracias por vicitar nuestra tienda")
                End If
            End If
        End If

        'Espacio entre codigo para el calculo de cada producto '

        subtotal5 = total5 * -1

        If selec = 5 Then
            Console.WriteLine("A seleccionado Iphone 14 pro max - $990")
            If total5 = 0 Then
                Console.WriteLine("Muchas gracias por su compra, vuelva pronto")
            ElseIf total5 > 0 Then
                Console.WriteLine("Muchas gracias por su compra, su cambio es de $" & total5)
            ElseIf total5 < 0 Then
                Console.WriteLine("Lo sentimos, su presupuesto es insuficiente para compar el articulo")
                Console.WriteLine("Falta un total de $" & subtotal5)
                Console.WriteLine("¿Desea agregar mas dinaro al presupuesto? (1)para continuar o (2)para finalizar")
                more = Console.ReadLine
                Console.WriteLine("------------------------------------------------------------------------------------------")
                Console.WriteLine()

                If more = 1 Then
                    Console.WriteLine("Monto a agregar")
                    Console.WriteLine("Dijite el monto extra")
                    extra1 = Console.ReadLine
                    final = extra1 - subtotal5
                    If final = 0 Then
                        Console.WriteLine("Muchas gracias por su compra, vuelva pronto")
                    ElseIf final > 0 Then
                        Console.WriteLine("Muchas gracias por su compra, su cambio es de $" & final)

                    End If

                End If
                If more = 2 Then
                    Console.Clear()
                    Console.WriteLine("Gracias por vicitar nuestra tienda")
                End If
            End If
        End If

    End Sub

End Module
