require 'scape.rb'
require 'occupado.rb'
require 'snake.rb'
require 'wall.rb'
require 'food.rb'

class Board
  attr_reader :tiles, :side

  def initalize(lado)
    @tiles = Array.new
    @side = lado
    setup()
  end

  Tile elswitch(row, columna)
    pho
    pht
    switch(row)
      case 0
        pho = Pared.new
        pht = Tile.new(pho)
        pht.posicion(row, columna)
        return pht
      #end
      case 9
        pho = Pared.new
        pht = Tile.new(pho)
        pht.posicion(row, columna)
        return pht
      end
    end

    switch(columna)
      case 0
        pho = Pared.new
        pht = Tile.new(pho)
        pht.posicion(row, columna)
        return pht
      #end
      case 9
        pho = Pared.new
        pht = Tile.new(pho)
        pht.posicion(row, columna)
        return pht
    end

    pho = OcupaTile.new
    pht = Tile.new(pho)
    pht.posicion(row, columna)
    return pht


  def setup()
    @cuantos = 0
    for(i = 0; i < 10; i++
        for(j = 0; j < 10; j++
          @tiles[cuantos] = elswitch(i, j)
          cuantos++
        )
    )

  end
end
