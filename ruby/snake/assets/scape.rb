require 'occupado.rb'

class Tile
  attr_reader :position, :occupied

  def initialize(tipoTile)
    @position = [ ]
    @occupied = tipoTile
  end

  def posicion(x, y)
      @position = [ x, y ]
  end

end
