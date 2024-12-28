
var input = File.ReadAllLines("input.txt");
var movement = ">^v<v<<vvv<>^^>^<>v^^^>vvv><>vvvv^>>v>^v^v>^>v^^v^^v>v<<^<>v>^><<<<v>v<>^^^^>^^v>^^v><^<vv^><>><<v<v>^><^^^>v^^<>^v<<^^v<v<^^^<v<>^<<v^vv^v<><^<^^>^<>>v<<>vv<vv<^^<><v<<^^<^v><v^<<>v><v>><^^vv<v>>^v>>><^<>>vvv<<>^^<<<^>>^>^><^<v>vv><<vv<<vv<v<v<<^^<<^<<^vv^<<<>v>v>^^^>>vv><^>>><<vv>><<<>>^><><v<v>v^^^<^<<><<>v<<^^vvv<v^^^v>^v<v<><>><<><>vv^<<<><>v^^vv<^<><vvv<^^<^>^<vv<^v^>^<^>^<>><<v><^v>><<<<<>><^^>^^v><<<v>v^v>^^<v<^<<>v^v<<>v>v<<>>^v>>vvv>>v^v><^<v^<<<<v<<<^vv^><<>v<^v^v<^^vv^>v^>v^^>v><<^>^<v<<vv>^<>>v>vvv^>v><v>v>^<>^<><^>^^v<<>vv>v>>^^v>>^v^><^v<^><>>^v>v^<^>^v^>^<<>>^^v><>v<>^^>>^>v^<^v<v><<vv<^^^v^vv<^^>^^>v>vvvv><vvvv>v<<>>><v><v^^v>>><v>>^><v>>>>^v>^>^vv^<><>><><^v^v>^>>^>^><vv>^v><v^v^><<><^^v^^<v^vv^^<v<v^vv^^<><v^<<>v<><<^<>>>v>>><<<^^vv^^>^^^^v>^vvv<<<>>^^v^<<v^<><<<>>v>><v<<<>^>v^^v><>^>v<^>><^^vv>^^><>><^<>><^^<v^^><>>^>^^^<<><<vv><><v<^v^>^vv<^>><^^vv><>^>^>><v<>>v<vv><><<vv>>^^vv>^^><v^v^<v<^<<>^v<^^vvv^<>^>v^v^<<v^^v>v^>^<vv>^v>v>>v<>><<v^v>v<><<^^<>^>>v^^vv^vv<^>><\r\n>^><^<vvvvvv^<>>^v>>^<><vv<^v^<<v^^>^>v^>>v^vv>v<v^<>^<>v^v<<^^<v>>v>v>>^^v^^v^>v<^<^<>><^^v^<^<>^<^<v>>vvv^>>^>^>><>^^<v>v<vv><v>^^<<>v^^^><>>^<^>v^^<<>v<<v<>^^<<>^^v^^<<^>>^v<^<><v>>v^vv>^v^><^<<<vv^><>^^<<vv<>v>^>vv^v<^^v^^^<^<vv<^v>^<v><v>^vvv^vv<^v^<><v><>^^v^>><^v^v><v<^v>>>^><>><<<vvv<^<>^^vv>v<vv<vv>><^<<<>>v^<>><><vvvv<^>>v<><<^vv<>^<>^^vv<><^<v>>vvvvvv>>>>>v>^>v^^^<^v<><^<^v>v>>vv<<<^<>vv^<v><>>^<v><<^<<^<^^>^^v^<v<^v><v><v^^^>v>v^><^><^^^v>>^>^><<><><<^<>><<vv^<v^<>^^v^v<><<v<vv^^v<v<>v<^^^<v^<^<vvv^vv<>^>^vv<<<^<<<^>^^vvvvv<<v>>v^>>>v^><vv><><>v>v<><v^vv^<<vv^<>v<^^><v^^<<>>^v<^^>v<vv<<><><^^^v<^<v><v^>>v>v>>v>>>><v>v<v<><>v^<>>><<><<<<>>^^^^>v>v^>><vv^v^><v^>>^^>v<vv^><v^vv^^^^^^v<<^^^^>>>^^^>v^<<><^<<>>>^^<^>^<^><^><>v<<<^^^>^<^<^vv>>^>^>vv^<<^<v<>v><^^<>vvvv>^<>>>^<vvv^v^>v^^^^>v^vv<>>v><^v>>>v>^^vv<^v>^v><>^><v>^<>^^v<^^<>><^^v<^^>^v>>^>>v><><^^>>>^vvv>>^v<>^>>^^><v>>v><<>v<><<v<<v<vv^<>^v<^>^v^vvvvv<>^^v^^vv^^<<v<<^^v^^<<v<^^<^v<v><^v<^><v^>^^^vv>^<^^<>>vvv^>^v^<v^vv<v\r\n<v<v>>v<>>>v><<<^v>>v>>^vv>v^<^^<><v>^^<>vv^>>^>>><v<<>v><<<<^v>v<>>>v>v^v^v>^^<^v<<^v<><<<^vvv>^<>>^>><>>v<v<v<v^><v<<^^^vv<^<>v>v><<v^v>^^^vvv>>vv<<><>^v<<<^^^>>>>>^v>vv<<<^<^<<^v^^><^>^^^^vv<v<<<v>^v^v>>>^^>vv^^<v^^>><^^<v>^><v>^v^v>^<>^<^>>>v>^^v^v^><<<v<>^v<vv^>v><v>>>^<>><<><<^^<<>^^vvv^^<<^><vv<>v<><><^v^<^>v>v<v>>>vvv^v<^<><<v<vv<v>>^^<v^v^^<>><^<<^v>v^^v^v^^>^><>^^^v>vvv>v<>^v><^^<^^><>>vv^>v<^^v<<<v>>v>^<vv^<^^v><v^^^^^<vvvvvv^<>>v>^v^v><v^^><><>>^v>^<<<><<<<^^>^<v^<vv^>^^><v<^^^<^<>>v><>^v>^<<^vvv^^<^^v^vvv^>v<v<>>^^^^>><^>>^^<^<vv>^><<v^<v<>^><<><<>vv<^vvv<^<><<v<v^^<^>v<^<^v<v<^^<^>^<v^>v>>v>vv<<><vv^^v>>v^><^vv<>v<^^<>^v^>>^>v^<vv>><>^^v><v^>v><<^<vv><>><v>^>^^<v^>>><v><>v^^v^>><^v><<>^^^v^vv^>v^^vvvvvv>^>>>^><^>^>vv<v><v^<v<v>^^v<<^<^<v<v>>>>^^^^>^vv<>^vv<><^>^>^^>v<<<v<>^<<v>v^v^>v>>><><^>vv<^<^^>>>>^vv^^v<vvv<>v><v<vv<^^<>v<v^<^<<^^<vv>><<v>><vvv>^^<<^^<^v>^<^^v>^<<^v>><^<v<>v<^v<v<^vv>v^<>>>>>^vv<><<<>^>v>v<><<v^<^v^><>v^<>v<^v><><>v<>>><>^<^v^<v^^<^vv<<v<<<^vv^^<>v>^\r\n<<^<<<<<>^>v^v^vv^>><<vv<<v>^><<vv>>^v<^v^>^^^^v^>v^<v>v<<^^^v<^>><v^vv<vv<>^<>^<^<v<><^^v><<>v<v^>^<vv>v^<^<>^><v>^^^>>^^>^^v<>v<>>v<^v>v<<>^><vv>>>v><vv^vv<^<^<<v^<><v>>v^<<v><<^>>v<<^<^<>><><<^>^>>^<<^^vv^v^>^^<<>^^v^>v>^^<>>^>^>^>^^^^<^vv<^vv^^v^^>^^v^v^^v<^>v>^v<>>><>^>v>>^<^><v<^v<^>^<vvvv><v^<^><<<^v^^^<>v<<>v<<v<<vv<v<<^<vv><^<vv<>^^<><><>>vv^<^>vv<>^<^<vv<^>v>v><^^>>>^<<<^<<<^^v<><vv><v^vv>v>v^><><>v>^><v^^v^>>^>^<<<<<>>>^>><<<<>>v>><^^>>>^v<>vv<^vvv^^<>vv^><v<<<v>>^^>^>>^^>^^v^<vv^v>v>>>v^^<<v><<>><vv>>^>v<^<^vv>v<v<^<^<<<v^<<v^<<>v>>vvv^>>^>vv<^^>v^^>^><v>v^<<v^^>>^v<<v>>>>>^v<<^>>>v^^v^v^>vv^^<><^^>v>>^<v^^v>>^vv<vv^^v<<v<^<><>>v^^v><<<>v<v<>>>>>><^^<vvv<<v^<>v>^v<v^^>vvvv^v^v><<^>v>>v^v>^^^>v^<v<v^<<v<>>v<<^^><>^<<>>><<v^<<^>v>^<><^^>^><v^<v>vv>^>^^^^>>v<v<^><^v<v^^<>v^>v^><^<v>>v^v>v<<<>v><^>v^v<>vv>^<^<<v<<^v><>^vv<>v^v><vv><><<^>^<<^>><>v>^>>v^><<v<>>^^vv<^><^<^v<<v^>><^^^><>v>^<><>^v^<>>v>>^>>>v<^>v>v>v<^>v>^^^<<<>^<>v<^^<<>v>^<<v^<<vv<^<v^>vv^>>>^vv^^>v>>v>^><^v^>v<v>\r\n<<^>v<<^>>><<v<<^^^<>v^<v>><<><>v>v<<vv<>v<>v^^v^^vv<><^v>^>^<<v^^^<<<v^^^><^^<vv>v<^<>^<>>>v^^v><v><<<>^<>>v^v^<<v^<v^^<^^><<<v<>^>>v^^v>><>v^v<><^><v^<v>^vv^><<^^^v>^<^v^>^>v<<^>vv<>vv<v^^>^><^v>>v>^^v><<<^<^<vvvvv^^v<<^^>>^vv<vv^<<<^<<v>^><>>>>vv<<>v>><v^v<v^vv^^^^>vv>^v<>v^^vv^^vv>^<<>^<v>><v<vv>vv^^^<^^vv<^<<<vvv<<^^v<vvv<v^><^<^^vv<<>v^>v^^><vv<>>>>v><^^v>v<v><v<^><<v^v<>><>^>^v<^<^^vv>^v^<v>>>v>^v>^^><^><v>vv<<^<>vv^>^^>vv>^v><v<>v^v^v><<>>^>><<^<<<v^v<<^>vv<v>v>v<^^<>^>>>^^^v<>>^<>^v^<v<><<v<v>vv<<><>v><^^<>vv^><<><>v^v^^v^vv>>>><<<vv<<>>v<^<v>^<^>>v<^v>v^<<>^>>>>><<><^^v>>>>vvv<v^<>>v^<^>^^>v<<><>>v>v^v^<^<>v>vv^v>^<^^<>^vv<><^v<<vvv>>^v<v<^<<>v<^<^<<v^v<^v>^<<>v<>>v><<<>^<vv^v>><^^<^>><>>^^v<<^v^<^<^vv><^<^vv^v<^>^^v<v><^^<vv>v>^>^v>>vv^>^>^<><v<<v<>v^v^^>^^v><^<><v>>>vv<<<>><<v^><^v<v^>v^<>^v^<^v^>^>>^v^<^v<>^<>v<v<v><>>vv<><vvv^^v>>^><vv^>^vv^<>^^v^^>v<<>^vv><<^^<^>vv>v^<>>v>vv^v^<>>>^>v^^<<><v>^>^^^v><v<<<^v>^>v^^>^<<v>^>^<>vv>^>>^<><><v<^^>>vv><^^>^^>^>^>v^^^<<>^>^>v><v^^\r\nv>v^<vv<^>>>v>^^^v>v<><^v^^<<<<v>vv<^^vvvv^<^^<<v>^>>^^<<^vvv<^v>^<v<^^^<v>>>v^^v<v<^v>v><v<>vv><>>^^><v<<>^>^>><><^v^>vvv<><^v^v^><<<>v><vv<v^^v>^^>^<<^<<><>>^>^^<<v<<^>>v<>^<^v>>><^<<>v<vv>vvv>><v>^^v^vv<<<>><><vvv^<^><^^<<>^v><<>>^>^<vv^v<^v<<v^vv<>v<>>>>>^>v^>>v<<><<v>vv>>v^><^vv>vv<><><v>^<^^^>>v<<>><v^>>>v^v<>^v<v<<vvv<>>v<vv^v<v<<^^>^><>^^><^^><^>>^^vv^>v^>^^><v>^v<<>vv><<vvv>vv^v^<vv><>><<>v><vv<>^><vv^>^^^^v<><vv<<^<><<<vvvv^<vv^v^><>><^^^><<^^^^>><v^^v^<^v^v^>>^vv>>^^<<>^^^v<v^vv<<^vv<>v<vvvv>v>>^>v<^<v<vv>v><^>vv<v^<^>>v><<vv>v><><^<^<^v<<^<>>^^>^<^><>>>^^vv^v<v^><>>^v>v>>>>v><>^<^><><^v>><v^vvv>^><^><>>^^<>>^>>><^<>vv<v><v^>v^^^>v<><^<>v^v>>^>>^v>>v<>>>v^^^^^^<v^>vv<<<^><<vv>^>>v>><v>^^v>><^vvv^>v>>v><^^v^^<^><v^<vv><>^v>><v^^v^^^<vvv>^<<^<<>>vv^^^v^<<<^v<vv>v^^>><^<v^>>^<v<>>>^<>>^>vv<>v^^>><>^<v><<v<^<v<>vvv><^<vv>v>^^>^<vvv^^^<>v^<v<><<v>><><vv^v><v>^v<><^<vv><<<vv^>^^<<vv><v>^>^^v<><><>vvv<^^v<<<<<<<<^v<><v<v><<><vv>v>>^<vv^v^>><<v^>^^>v^>><v^>^^v^vv^<vv>^>v>v<v><<><<<<\r\n^<>^^v^^<^^<>v<<<<<^vvvv<>>^vv^><>^vv><>v<^<>>v^v^^<><<v<v>v<<v<>>^<v>>v>v>>v^v<v>vvv>>>^^>><vv>v>v<>><<v>vv><<<v<<>v<><v^vv>^>v>v<^<>v<<>vv^v<>v<v^<<>vvv>v<>v<><<v^>^>v>>>>><>>v>v>^v>^^><v^<^<^v<vv<v^v^>^v^v^<>><v>>>><^^^>>^><<<<<v>^^<^v>^<^<^><^>>^v<>^>>><><<vv<^<<>^><>v<v<><><v>vvv<vvv^><><^><v^>vv^vvv<v>vvv>^><<^^>^>>v<^^<<>>^>><v<v^v^^v<^^^<^vv>^v>>>>><>>><v>>^v>>vv^v<<<v>><v^^<<<>vv<^v^v^><<>v^^v<^vv^v>v^<<v><>^vv^^>>vv<<>^v^^<^<v<>^^v^<^>^^<^<>^^>v>^v>^<>v^^>v<v<^>>v^><v^^v>v<^vv<<^^^v^><><v<vv>v>>>v<^><^>>^<v^<v>>v<^v<>^^^><^v>vvv^^<<>^^<^v>>>>><^^<^>>>v^v^<vv^<vv<<>^v^<<v>v^<^v>vv^^^vv<><^>^^v<>v>v^><<v^>^v<v<>><<^^<vv>>>>v><v^>>v><>>^vvv>vv>><<<v><^>^v<><^v>^>>>>>^v^<^^v^<>v>^<^<>vv<v>^^<v>v>><^vv<vvv>vv<^<>^>v><>v^<><>vv<^^vv<>^v^^>^^^<v>><v>><<>^<<<v>v<<vv<<>v>vv^^v>>^>^><<<^<<^vv<^>^>v^>v^vv^v^^<^vvv<^v^><^^>^^^^>vv^^^>>^v>>vvvv<<^vv^<v<vvv^<^<^v<^^><>v><<<<v>v><>v>vv<v>^v<<^<^>>^v><v>>v<v>v^v<<><^v<^v><^v^>v><><v<^^>^>^>v<>v^>>^^vv><^<>>>vv>v>v^^v^vv^^<v><^<<<><<<<v>><^^v\r\n^^^<<<><v<vvv>v>>vv^>^v<v^^><v><>vvv<>vv<^vv>^><v^>^<>>>v^>v<^><<^v^><^<v<<^<^^>v<<^vvv^^^<<<>>v>^^^<<^>v<vvv<v^^<^v^vv>>>v^^v^^<vv<>><<>v<<>v^>>^>><vv^v<v^>vv^v<v>>^<<v<vv>v<v>^v>^v>^<v^<>vvv>v<<v>v>>^<<v^<<>v^v>>><>vv<<<^^>vv^vv<vv^><v<>><^^^<v^v^<><><^^<^<<>v<<vv>>><<<<^vv<^^v>>v>^vv>^^v^>^^>><^<^v^<<v<><vv>>^^^>>^vvv><^>>v>>vv^<vv^v^<<>^^><<v<^>>^<^><><>^<<<>>vvv<v^v>v>v>v^<<^vv^<^^<<^v>><<<^v><>^>>^v>^>v^>v^>^<>><<<<<^><v<<>><v^vv<><>^^>><^<^^<v^vv>>^vvvvvv^<^<v^<v<>v<<<>>vv<<>>vv<><<<>>v><>v>v^^>>><vv>>v<^><v<<vv><vvv<v<v>v^^>>v>^^>>^^<<v<><v^>v><><^<^^><^^<^^vv^><^>>^>><v^^v>^<v>^^vv<^>>>>>^<vv<>^^^<^<^v>><>v^<<<v^v><<><v<<^>v><<>^<<<vv><>vvv<>v>v<>vv>^>v><v<v^<v>><<vv>v^<^v^^^^^>>vv>v^^v^<>^><v^v^^<>^>^<>v<>>^^>^><<<v>>>v>^^>^>>^<<>^>v>v>v<<<><v><<>^vvv^vv>^><v<<^<<<><<^v<<^^><v<^<>^>>^^v<<v>vv<v<><^^>^^^<>^^^<><v><v>vv<<<><<^<<<v^<<>v<<>^><>>>v>v^v>v<vvvv<v<^<<^>^v<><<v><<>^^<>><>><^<^v>v^^<>>^^><^<vv<<v^^>vv^vv>v<^^><vv<vv^<<>vv^v^^><>>>>>v^<v<^<<<<^<<<><<^^v<^^><<>v^>>v<v>v>\r\n><<<<<<>>vv<>>v>^v>^v>>^><v>^^^>v<>vvvv^v>^^v^^<^v><<<v>>>>>v^>>^v^v^^>>^>^>>>>^>^>^<<>v<>^v^>>v<^^>^><><<^><><<^^<<>>^>>^>vvv<<><<>v<>>>^^^v^^^<>><^v^^>v>v^^><<<>^>vv^<vvv^<>^v<<><<<v<vv<>v>v>^^>v<v^>v>^>>v>>><>v>v^>v^>^>>><>v><^<>v><^v<<v^>v^^^v^^^^^v^v<v^vv^^^^<^^>^>^>>vv><<^^v>^>^>>^<vv<v<<^vv^><<vv^<^><^><^^>><^>v<v<^<v<vv^>v>v<<>^^><><>><vvvv^>>v<<v>v^^^^^^<v<<<v^v^>>>^v>^vv<v^^^>>>v>v>^>v^vvv^v<vv>vvv<>^>>vv>^^v<>^<>v<v>vv>><<>^v^>v<<>^<<^>vv^v^v>>v><vv<v<<<v<^><^<^<>vv>><><^vv<v^>><>v>vv<^^>>v<>>^v^^^<<<>v<^<<^^v><^v>v<<^v^<v><<><>^<<<><>v^>^v^^^vvvv^^v>>vv<vv>><<>>^>v>>^>^><^v<><v<<<<v^v>v>>>>^>^><<<^^v>vv<>^>^<^><<^>>^<vv<>v>^>>^<<^v<><^<>><v>v<>><>v^v>><^^^^^^>^vv>>v^v^^v>>^>>>>v^vv<>vv^>^>><>>>>>v^^<^>>^<>^v^><><><v<<vvv^^<v<^<<^<^<<v<>vv<^<<v^<v><v>^^<v>^><<>>><>>v>>v>vv<>>vv>><<v<<>^<v<v>^v^v^^v<v<<vv<^>>><>>^vv>^<vvv<^<^v<v^<^<vv><>^>>>>>v<v<<>^<<v<<^^^v<<^vv<^<v>^<>^<<<v<vv^<^^v>>^<^^<<v><><v><<vv^^v^^>^<vv<<>>><><>^^vv<vv>v<vv><<<v^>><>^<^vvvvv<><<>vv^<^>><v^>v>>><<<v<\r\nv<>>v>>^^><<<^<vvv^>^<>>v^>^v>><<vv^>>^><^v<><>^^<<<><<^>^vv>v<<^>v<<v<>>v><<<^>><<<v^v<^<<>^>>v<>><>>v^^^>>^>^>^<^v^v>^^^<<>>^>^><^^^>v>^^^^v^>>>^vv^vv^^^^v<>^^<>^^>><>^v>v^v<<><^>>vvv^^><<<v<^<v>^>>v<<v<<v<^>>>>^^^<v>v^<><vv^<^v^v<>^^^^>^^v<>vv<vv>>>vvvv^vv>^>v>^<<<v^>><^^<^^^><><<v<<>>v>^>v^^<<>v^v>^>^v<^^>^>>v<<v>v^<>^v^<<v<v^>>v>v<vv^<^><><<^<><^><^<<^^<><>v<^^^v<^^v<>^^>><v>v^<v<v^>^<v>^v<<>^>^^<^v^>><><>>>>>^<>vvv^<v<v^^v^^^>v^^<>>v>>^><<><^>v^^<<<v<>>v>v^^v^^<<<^^<<v<^<>v>^^<^^vvv^>^><>^<<>>^^<^>v<<<<<^<<>^vv<^<v^<<<<>^^><<^^^<vv<vv<^v<>v<>v<>><><vv^v^>^<vvv>><><<<^<>v>^v<><>>><v<>^v<vv<^^>^<v<v^<v><><^>>^v>>^vv<<^>>vv^<<vv>v>><v<><>>^>v<v<v>v>>>v^<>^<v^<<<><v<><<>v^^<<<vv<<><^v<<><<>>^^<^^<^<><<>vv<<^>>^^>^v^v<^vv^>^v>^vv^<v<>^^<>>v>v<v<<^>^^^^^><><v<><>v<v^>>v<>>^>v^vv^<<<<v>^^>v>v^<^v^v^<<>><v^v^v<<>^>>>>vv<v><<^v^vv<>^>^v^^<vvv>^<^>^<v^>>vv^^>vv^^v<^^<^<>^^<^vv>vv>v>^v><^>v>>v<v<><>>>><v^<v^<<v^^v^^v^<^>v>^vv^^v^>^>>vvv^^<v>^><>vv><>^>>v>v><<^>>^^^vv<vv><<v<<>>vvv<^<<>><^><\r\n^v>vv^^<v<<>^^>^v^<vvvv^v>^^^v^<<^>^^v>>^>^^<<vv>vv^<vv>>vvv>^<v^^vvv^^v<^<^^><<><>^v<<v>v>>^v><v>>^<^<v^v>v^><^<><v^<<><^>vv>v>v<<<<^<v>v<>>^>^>>^<<^<^^^>^vv^<<<<<>^v<<>v^>v<>^<^<v<>^<>^><^^>>^><v^<<^v^v>^<>^^^v<<<<^v>>>v<<<v<<^^<^><v>^^<vv>v><v^v^v<v^v^^v<v><>>vv<<v^^<^^>>^<>>^^^vvv<v>>^>vv<>><^vvv>><vv<v^>^<^<>vvvv^<^^v<><^v^><><<v<>>^^<>><^<<<<<>vvv^<v^^<vvv<<><<^vv<^v<vv^<^<<^><<<^><^<^<vv>vv<<<v^<>^<<>v>>^^>^v^>^>^>>v<>^v^v^v>v>v<>v<v><<v>>v<<<^><v^>>v>^^<<^^<><v>v^<><^v<v<^^v^<>>>>><>^^^>^v>>^^>vvv<>>><>^<v>>>>v<^^<v^>^<>>><<<^v>v^<v^^v^^v<v<<<>vv>>^>>^vv^^>>>^><^^>>>v^^^<v<<^<<^>><>^<^<<v<<<>^^v<^<><>>vv>>^<<v^vv<^^v<v^^>v<^>v^^v>v>v<v>>v<<<^><><><^><<v><v^<<^v<^>^>>^<<^^v^<>^<v<>vv<>>v<^><^^^v<v<<><<vv^<<<>>^v^^^>^vvvvv^<<>v<<<vv<>v<<^<^^^<v^^<>^>^<v>v<vv><^<^^^v^v^<v^<^<v<>^>^^v<<>>^<>^>^v^<>v>v^>v><<><v^vv^<<^>^<vv>><>v^<v<^v^vv^^^><>^^>>v><v>^vv<>v^<<<<>v>v<v>>>^v<>^>^<^>^^<^<^><<<v<><^<v^^<>>^<><v^^^v^<<<<v^^><<^^^v^^^><<v><<>v^^^<v^<>^<<<^^v^^<v>><<<<v<v^v^^<<v>^^v<>><vvv\r\n^v<>><v>>^^^<<^v<v<<^>^<^^<<<v<v^><^^vv^v^v^v^^>>vvv^><vvv>>^^v^^^^>>>>vv>><><v><>vvv^<^v<^v^<^<v<^><v^>^<<v<<v>vv^^^^v^^<v<vv>v>^<vvvvvv^v^><<v<<vvv^^<^>v>v^v<><<v<>vv<^v^v><v>>^><vvv>^><^>^><^>v>^<><v>v<v><^^v>>^^>>>vvv>vv>>v<v<<<>vv<<>^>^><vv<><^<<^vv^vv<<vv^v^vv<v>>v<<^<^<vv^^v<^^v^<^v>^^v>^<>>>vv><^<^<^>>>>><<>^^v<v><>><^^<^v<>v<^<<>v<v>^<v>>v<<>^<v^^<^v^>>v<>^>>^<^>>v>^<v<^<>^<v<^<^^^<<>v<^<<>>vv^<v<<>^<v>vvvv>^<>v>>>v<>v^v>v^<^<^>vvv<><>^>^>^^<v^<<>^<v<vv<^^<<>v<vv^>>^>vv^><<v><<><^><^><<^>v>vv^v^>>>><<vv>>>>v^^v>v<^v>v^<^^^^<<>^<>v>>^>>vvvvv>>^v^^^>^>><>^<<>v>vv<<v>^>>v<v><^v>^>v^<>><>^v^v<^<>^<v>^>v><>^vv^<vv><v^<<v<v>>^>><<><><v<^>>>^vv^<v^<vv<^^>^><>^vvvv>>>v^^>^<<>^<^v^vv>><>>>v^>v<<v>^^v>>>^>v^<vv<<v>^>>>><>^>>^^v^v<>v>vv^^v^v<<v^^v^<^v>^^<v>^<^^<>v>vv>^^<>v>^>>v^v>vvvv>^<vv>><>>v>^<<<>v<<<^vv^<<v>v<vv^^v<v^vv><vvv<<^^^^vv><vv>v^v<vvv><^>^^v^^v^v<<><<^>v<^v^^<v^><v>>><<<v<^<^<>>^^><vv><v>>^<v^^<^><><^^v^<<<v><<<^<v<^^v<^>>^vv^<><^v^^<v<^<v^<>>>>>^v>v^<<<>^^>>>><>><<vv<v>^<\r\n^>>v>^><<^<<v>^^^v^<vv<v><<<^>^vv<>>^><>^>>v^^v>v><>v^v^^<<v<>><v>>v^<<>^^><>><><>vv>^^<^><<^>v^>^>v^^<<^<^<<<>^v<v^<^^v<>^v<>^>>vv>v><>v^<><>v<vv^v<>vv<^>>>^v<><^<^^^<v^><v^v^^<<^^><>v>><^v>v^>^>^v^v<>v^><>><^v>><^v>^<^<^vvvv<<<v^v<<v^>>v<^^>^>^>^<vv^<^<v><<<^v><>>><^^>>><>^^<v<><<<>>v>>><<vv<>^v^><><<<<v^v<>v><<v>>>><v<v><>v^^^^^>>v^^<>>>vv^v<<v^^v^^vv<v^v<^>vv^>v>v>>>^<<^^^<v<v<^^v>^>^<v<>^v^<<<vvvv<v>v>>^<^vvvv^>vv<vvv<^>^v<^^<>^v<^<>^^<v>^^vv>><>^<v>v><>vv>v>><<>v><>>^v>v<^^v^><<v><^v>vv><><<vvv^v>^<<v<^vvvv>^><>v^vv>^^v<v>^>>v>^><<^<v<<>^>v><><^<<<>v^<><>^v<^^v>>^<>>>>^^><v^<><<>v<^>>v^^^<>>^<^^^v^v<>^v^<^v<>vv>>^^v^v<v><^^>><<><vvv^>v<<vv>v>v>vv>^<<v^vv<^<<>^v<v<vv>>>vvvv<^^^v>>>>v^^<v>>vvvv<^^v^<<>>><^<>^v>^<>^v<<<v^<v^<^>>^v^<<v<>v^>>>v<<><^^^>^<v<^>vv^^<<v<>vv<<<^^<<>>^><<<<v^^<^v>v^^^>v>v^^>v>v<v>>^v>>^><<<>^<><>^>>^^^>v><v<>>^<^^^><>^<^v^v^vvv>v>vv>vv>>vv<v<>^>v>><v>><<^vv<<>>v<<<^><v^vv>>>v><<v^>^<v>v><<>><^^v>>^<v^>^<^<^v<<<^^<<v<>vv<vv<<v>^v><vv^vv>>v<>v^vv><<<v><^<v<>v<\r\n<><v>>^<>vv>v><<^v><>vv<<><<<><v^><v^^^>>><v^^<>^^<^>v^^><v^<>>v>^>>>>>^<^^^^<<>^v^>vvvvv^^^<<v<v>><<^>>>vv^v><><<^vv<^^^>^>>v<<^><^><v<^^>v<^^>vv<<<<^v>v>^v^vvv^v<^v<<^>^>^vv^<><<vv>v<v>>v>>v^^^<^^>>v^<^v>^v><^^>^<^<>vv<^>>v^^<vvv<vv^v<vv<vvv^<vv<v<>^v><^>>><^>^^vvvv<<^v^vv<<<>v>v^>^>>^^v^>^>v><v<^v^^<^v<<<v^vv<v^>v<^<^>vvv><>v>><<<^<vv^><v^<<^<><>v^^>^^<vv^vvv><>><>vv<^<>>>v>vv<^v<v>^>^^^<<^>^><^>v^^<>v<^v<v^vv>v<><^><>>v^>v><v>^v<vvv^<>>^<<^<^^vv>>>v<>^v>vvv^vv^^^>^vvv<v^v>^>v^v>^<v<>^>v>v<<<><><>v<^v><vvvv><^>v<><v>vv<<vv<<^^^v<>^^^>>v><><>>v<^^><^^<v>>^^^^>v<^vvv<v^<><<<v^^<<^v>v<^^>v^<>vv^<v><^v>^^v^vv^><>^v^^^^>^^>v^>v^>v>v>^><^><>v^v>>v><>^><v<><v<><<vv^v<v<<<^v<<v>v<^v^<>^^v<<v<^^><>v^>>>vv>v^vvvvv>><v>>v<<<v>>^<<^><>>^>^v>>v><v><^^v^><>>^<v<>^<vv^v>^v<^<v><>v^^^<v^<<v^^<<><<v^v>^<^v>>v<v>vv<v>^^>v^v^>>vv<><>vvv>vv>><^><^>^vv><<^^>>vvvvv<<<v^^<v^^vvv>>>^^^^<^>vv>^vv<>v^>>^<v><<<^^v>^>vv>vv^>vvv^^^^<v>>>>v^vv^^>^>><>>>>><<^vvvv>^vvv<^<^^>v^<vv<v><<<^^>^v>><^^v><^^vv<^v><v>v^vv>\r\nv>^<<>vv^<<<^>vv^<<v>^<^<v<>^<><^^<^^>vv><vvv<<v<v^<>><>^<^><v>><v><>v^^v<>v>v<>>^^><<vv<>>^^<<<<v<^<>vv><<v^vv>vv^v<vv<>v<^<^<^^^^vv<<v^^v^v<v>><><<<v><v>>v><^v^>vvv<><v>>vv^>v^<<<v<>><^<^^v><<^<^<>v^v^^>v^<^>><^>v>v>><<v<<^^>^^>>v>><<<v^v^^>v^v^^v<v><v^<<>>v^<<>vvv<>^<v^><^v>^v<^v><<^<v<<<>v^>>^>v><>v><^^<>>^^<><<<v<v<<>^><>>>>>vv>>>>>v<vv>^^v^>^><vv>vv^><>^^<vv^v^v>v^>vv^<>><>^<<><vv^<><>>>^>vv^<>>vv><<v<<vvv>>v^v><v>><<<>v>v^v<><<<^<^^v>>v<^><v>vv<<vv<v^v><<<vv>v^^<v>v^vvvv^<<><v^v^<<^v<<>>vv<v^v^^>^>v^<>><<<v^^<^^v<<v<>^^>><v<<^v><>v>v<><^>^^^<v<<>>v<^<><>vv^<<>v>v<vv<v>><^>^v^<<>^<><>>v^^<<>>><<v><<v^v>>v<v<<^v^^^v^^v<<<<^v>^^><><<<>^v<><<vv^^><v<<v<^^vv>><v>v^v>><v<v<v^><^^^^<^>^<^>v<^<<v^^^>v<<v><^>><<><^<^>>>><v^^<v>><<^<^<^v>^<<<v>^>v><v>><>^<>^^>>v<<v^^^<>^^>>>>^^^vv>vv^^<v>v<v<^<>v<v^<^>^v><v><<vv<>>>><<>v>>^^<>><>><^v^v>^v^^<<<^>v<><>^>>vvv<^^<>>^>^v<^<<<><<v><<^<<^^^vv>vv<<<>^<vv^vv^<v><>^><<^<v>v<^^^<^>^v^v>^<v<>>v<vv^><>v>>^v<<<^vv>v>>v<<<^<^>vv><>v>>><v>v<>v^><><^v^^^<\r\n<>vv<><^^><<<<>v^v>v<v^v<^<>vv><^>>^^v<vvv>v<v^><v^v>v>vvvv^<^vvv^vv<>v^^>v><>v<v^vv>vv^^vv<<<>vv>vv<<^v<<^><>v^<^<vv^^^^>><<^^v<v^<<>^v<^^^v>>>v<^^^v>^>^<<<<v<v^^>^v<>>^>>>>^<vv^^^^>v>v>v<^<<v<<vv><>>vvv<v^^>^><>^>^v>><^>^<>^v^^>^^<^<^v<<v<><<>^<v^vv>v<v<v<<v>><<<>vvvv^<^vv<v^^>>><v><^<^<^^<^>^<<>>v>>^^>><v>>vv>v^^v^>^<>v><>v^<>^><<^^><>>^><<v^<^^^v>^>v^<^>vv>>vv^>^vv<>>^<<>^>v<^vv<<>>v>v^^^^^v^v^^><vv>^^^v>^vv<><>^>^>v>^v^<v>v<<><^<<^<v^<<^vv^^<>vv><vv^^>^v<<>v^>vv<v><v>v^>^^>^^>v<v^^^<v^>^vv^>^<v^>^>v>v<<^v>^<v<^>^<v>vv^>vv<>^>^<^>vv>vv^v<^<>v><><vv^<^^^^vv^^<<v^v<<^>>><>v<>>^^^>^<vvv><^^v>><><v<<^^<<v>^^<v><^>^><^vv>><^^>^<vv>>v>><^>vv<<v^><^><<>v<>^^<^vv<<>v><>>^vvv>v><>>^vv>>vv<<^^>v>v>>vv^<v><>v^<^>>>vvv><v^^v^^vv<^<v<v^>>^v<^^<>v^><vvv<v>>>>^>^^<><v^^>><<<<v>^v<v^vv<>^vv<>^v>^^^v^>^vv^vv<^><<<<v<<vvv<>^<^^<<^>vv>^>^vv>vv<^^<>>v<v^v>v^^>>vv<^>^<^>v^<v><v>^vv^<^^^<<^^v>>>>>^<^vv>^^>^>^^>>^<<vv<^<<>^<><v>v<>v<<^^>^>^v^<<vv^vvvv<^>>><>>vv<^<v^<>^^v<<^<<<^^^^<><<v><v>><<<v^<<>>v>^><\r\n>><<^<<<<><^>vv^>>vv>^^>>^v^<<^^v>v<>v<v<v^><<^><<>v^><>v^<<<v<<<<<^>^>><>^v>>><<<v<^>^>><<v>^^<^>v>v<<vv><v<^<>^><^^v^^v<><vv^>><^v>^<<v><vvv^<^<<v<>^^vv<>>^>v<>^><^<>vvv<^>vv<v><v^v^^v^>^^>v<^>^^<<v><>v^<^v>^><><<><>><^<v<v<^v<vv><^>^>vv^<v>^><^>vv><><>vv<^^<>v>^<>vv<v^v>>>v>v^><^<><v>^v>v^v<^v^v>>>v^vv>>v>^vv^>^>><>>^^v>^v^^^^<v>><^>vv^<>><<^^v>^v<^<<>^v^<><^>v<<^<^>>^<>><>^^^vv^v>vv<>^>v<>v^v^^^^><^<vv><<^>^><<^v^^^><>^<vv^<^><v<v<v<^>vv<v^<<>^>>><v><>>><>vv>>^><^<>vv>>v^<>v^v^^>^>v<<><^^^v<^^>>^^<v>v>^<vv><v<^>^^^>vvv<>>>v^><v^^vv<<>>>^<>>v>>>><v>v<>v^^^^>v<<<<^^<^^<v<>^>^v>^<<><^>^vv^^<^>v^^vvv<vv^vv<v^v<>>^^>><^v>vvv>^^>^>^>vv^>v^v^vv^^^^v<v^vv>>v<^<><v<<<<<v><>>v^<^^<^<>>^v<^<<v>v^>^<<^<^<^^vv><><^^v<<<<v<<<^<<>^^^<>^v^^><>^>>vv^<<<^>vv<>v><^>>^v<<^>^^><v<^>>>^^>v^<^<<^^v>^v<><^<vv^<vv<^><vvvvv>^><v>v>>v>^^^^><>^>^^<vvv>>>v<v><<><<<<>>><<>^^^vvv^^>^^^<v^v<v<<v<<v^<v>^>>^>v>^v><<>^<v>^<^<^^<v<><^<<^>>vv^><>v<^<^vv><><>>^^^v><<>v>>>><>^><>>>><vv^<>>^v>^<v<^v>v>v><<^^v^<>>^vv<<^<^\r\n<v>vv<^<^<>^>>>><^<>v^<<^v<^^<v<>><v<v^>vvv<<<<<v>^<v^vvv>>vv^>><>v<^^<><><^<^<<v^^>>vv><><^<^v<^<<<^^<>><>>v^v><>>^<^v><^<^^<>v><^v<^<^<<>v<>^<^v<^v^^v>^><v>v^^^v>v^^>>^><^<^<<>^v>v<^vv<v^^<^>><><^v^<>v^<v<v^v^v>^^v<^<^^vv<<>>><>vvv^^<>^^>^<^v^<<>v^<^<^<v^^^>^>^v<v<>vv>>>^<<^v<v>v><>^v>^vv<v<>v^>>^>v>^<^<^>><v>vvv^<>v^^<>v^>><<>^<><>^>^<^^v^<^^<^^^v^<v><v^>>><v^^>>v<v>>><<vv<<><^v<v>>^<v>vvv^>>>>>>>v><>^>>^<<^<>^v^vv^>>v<^^^<vvv^><v<vv>^>v<>^^<vv>v^><<vv><^<vv>v<<^<<v<vv<^>><<^>^v<^v<^><><^<v<v>>^^<^><<<<v>>^v>><^>>^v^<<v<>^<><<>>v>v<^>>>^>>^^<<v<v<<<<^>><vv>>^v<<v<^<^v<<^<>^^v>^v>^^<v<^^>^><<<<^<^<><^><v<>^>vv^>><>>><v><v^><v>vv<<^^^v>^>v<^v>><>^<v>^<^^>v^<>>v<>v<<^^v^^>>vvv<><v<v^<<v<^v^>v^^^v>v>>v<<<<<^>v><<v^>v>>><v^<>>>>v>v^^<vv>><v><v^<^><>v^vv><<>><v<>^^>v<<vv>vv^<v>><<v^^>v<>v^^><>^<^>v><<><v><v^><v^<^<vv>^<<^><<vv<<<vvv^^<^v<v<>v><>><v<><><<v>^<>^v^^<>v<><<<<^<vv<vvvvvvv^>><^>vv^v<^v><>^^><v>>^>v<>><^><><^<>><>>v>>>>vv>^v>v<v>v<>^^<>>^<>>vvv^<vv^v^^^>vv>^vv>v<<>v>>>>v>^^v<>>>\r\nv>v^^<^>v^<v^>>v><^><v>>^^>>v<^<>>^>v^v>>v^v^v<>v<>>^v>><v>>v<^^^<vv>^v^vv>>^^^vvvv^v^vvvv>v>><vv<<^v>^>><vvv^^>^<^^v><^<v^><^<<^>>>v>>><<<><<^>>v>^<^^><><>v^v><^^vv^><<<vvv<^<<>>^^v>>^vvv^>v^>v<<><>v>v>><<^v^>^^^^<<^<><<>^^<^v<>>><^<vv<<>v<v^^>v^>>^<<v>^^vv<<>>^><^<<^<^vvv^>>>v^^^<<<v^^<<vvv>v^v>v>vv><^v^>^^v^v>>v<<^^<^v>^^v><>>^>^^<vvv>vvv<^v^<vv>^^<v>>v^^>vv^<<v^vv^<<v<v>>><>^>^<^^v>v>^v<^^vvv^>^>vvv<^vvv>^>^><^<v^^<vvv><v^^v>><<>>^><v<<<v<<<^>v^><v<<v^v^<^<<>vv><v<^^v^><>>^>>^vv>^<>vv><><<vvv^^<^<^>^><<^v<>><<<^<>v<>^<^v<^v^v<><<><v><v>v^vv<<^^<^>^>^^>>v<<>><<vv^<<>v<<^>^^^v><>>>><>><><^^^>vv^^>v^>><^<>^<^>v<^>>v>v<v^^v^>vv^v<<<><vvvv<^<>^v^v^>vv<>^v>v^>^v<<<^vv^<>>v<^<<^^^<<<>v<v>><<^^^^<>v<>^<<^>>vv^>><v>^<<v<v>><^>^<v>v>v>v>v^^>vv^vvvv^<v>>>><^^<<v>v<^^<^>vvvv<<<vv^<>v^v^<v^>vv>^><<v^><>^^>^<<^vvv^v^><^vv>^<<<v>v><><>>^^>v>^^vv<^^v>>>v><^<^v^<^v>>>^<>^<>^v^^>^^>><^><><^><^v^><<<v^<>^^^<<^^<>><<>v^v^vvv^>v<v<<<^>>>v<>vv>>>v^vv>>^<>>vv^^^^^^vv^v^>>>>>^><v^^>^<>v^^^><><>v^^^^<>vv<<\r\n^^<v>^>>>v<<><^^<^^<^v><><^v><v>>><>>v>><><<v^<v^<<<^<<v^<^^<^v><>v<<v^><^v<vv><^>v><<v^^>>>>^>>^^^v^v>>^vv>v^^<v^<>>^<^^^^v>>^><^v^v^^<^<<^^>^vv^^v^^v^><v^^^>^vv^<^vv<<>^>^^<>>>v^v<>>>^^^^<<^>>v<<<<v<^<>^vv^^>^>^><<<>v<>>><><^>^>^v>>v^v<><<v<^v<v^vv<>v<v>><>>^<v^>^vv>v>^^^>v^<v^v^>v^v^^v^vvvv<^^^^^vv>>v<<><<<>v><<<^^^><^><v<vv>>^><<<>^<^v<><v>>v><v>>^^<>>>^<^v<<^^>><>v<v^<^>^v>^<v>v>>>vv>>^^vv>^^v<>^<v^<vvv^>v^>>^<v^v^^<v><>v>>>^v><^v<>>v><^v>^<>>^<^v^>^<vv>v>^>^>>^>^<^<<^v<>v>>v^v<v>>^<^^<<>^^vv><<<<v>><<<><>^>v<><v^vvvv>vv^<><<^>^vv<<^v<v^<><><<>^>><^^v>v^<v>><<^>v<<v<<>>vvv<vv>^v<>^vv<v<<vvvv<<v^<vv><v^<^>><vvv><><vv><<>><>v^>>v^<<^<<^v^v<<>>><^<v<>^v^<^>v><^<^<^^^<<>^^><vv^>^>^^^^^^><vvvv>^>>^><<>^<<<<>>>>^<<>^vv<>^vv^vv><>v<v>^>^<<>v>v><<<><v<v<>>vv^^<<^>><v^<^>>vv>^>>vvv>^><^v^v<<><^^<>^^>vv<>>>v^>v^^^^>^v<<<^<<^><<^v^^v^<>>v<>v>^>>^^^^v^>v<>>>v^^>^<v>^v><><>><>>>>^^<vvv^<>^<<>v<>v<v<^<>v>^><<^v<v>><v<v^>vv<<<<v^>^v<v<^v><^<>>>^>>>>><v^vv<<>>v<<>><^>vv^><^><vv>^>><v^^^>>^<vv^vv>";

var moveMents = movement.ToArray();
var grid = ExpandInput(input.Select(x => x.ToArray()).ToArray());
(int row, int col) robotPos = FindStart();

for (var i = 0; i < moveMents.Length; i++)
{
    if (moveMents[i] == '\r' || moveMents[i] == '\n')
    {
        continue;
    }

    var dir = moveMents[i];
    if (dir == '^')
    {
        var boxes = new HashSet<(int row, int col)>();

        var canMove = CanMoveVertical(-1, robotPos.row, robotPos.col, boxes);

        if (canMove)
        {
            for (var row = 1; row < grid.Length - 1; row++)
            {
                for (var col = 1; col < grid[row].Length - 1; col += 2)
                {
                    if (boxes.Contains((row + 1, col)))
                    {
                        grid[row][col] = '[';
                        grid[row][col + 1] = ']';
                        grid[row + 1][col] = '.';
                        grid[row + 1][col + 1] = '.';
                    }
                    else if (boxes.Contains((row + 1, col -1)))
                    {
                        grid[row][col] = ']';
                        grid[row][col - 1] = '[';
                        grid[row + 1][col] = '.';
                        grid[row + 1][col - 1] = '.';
                    }
                }
            }

            grid[robotPos.row][robotPos.col] = '.';
            grid[robotPos.row - 1][robotPos.col] = '@';
            robotPos = (robotPos.row - 1, robotPos.col);
        }
    }

    if (dir == 'v')
    {
        var boxes = new HashSet<(int row, int col)>();

        var canMove = CanMoveVertical(1, robotPos.row, robotPos.col, boxes);

        if (canMove)
        {
            for(var row = grid.Length - 1; row > 0; row--)
            {
                for (var col = 1; col < grid[row].Length - 1; col+=2)
                {
                    if(boxes.Contains((row-1, col)))
                    {
                        grid[row][col] = '[';
                        grid[row][col+1] = ']';
                        grid[row-1][col] = '.';
                        grid[row-1][col + 1] = '.';
                    }
                    else if (boxes.Contains((row - 1, col - 1)))
                    {
                        grid[row][col] = ']';
                        grid[row][col - 1] = '[';
                        grid[row - 1][col] = '.';
                        grid[row - 1][col - 1] = '.';
                    }
                }
            }

            grid[robotPos.row][robotPos.col] = '.';
            grid[robotPos.row + 1][robotPos.col] = '@';
            robotPos = (robotPos.row + 1, robotPos.col);
        }
    }


    // Works as in 1
    if (dir == '<')
    {
        int? col = FindSpaceHorizontal(-1, robotPos.row, robotPos.col);

        if (col is not null && col.HasValue)
        {
            var endCol = col.Value;

            for (var j = endCol; j <= robotPos.col - 2; j++)
            {
                grid[robotPos.row][j] = grid[robotPos.row][j + 1];
            }

            grid[robotPos.row][robotPos.col] = '.';
            grid[robotPos.row][robotPos.col - 1] = '@';
            robotPos = (robotPos.row, robotPos.col - 1);
        }
    }

    if (dir == '>')
    {
        int? col = FindSpaceHorizontal(1, robotPos.row, robotPos.col);

        if (col is not null && col.HasValue)
        {
            var endCol = col.Value;

            for (var j = endCol; j > robotPos.col + 1; j--)
            {
                grid[robotPos.row][j] = grid[robotPos.row][j - 1];
            }

            grid[robotPos.row][robotPos.col] = '.';
            grid[robotPos.row][robotPos.col + 1] = '@';
            robotPos = (robotPos.row, robotPos.col + 1);
        }
    }


}



var score = 0;
for (var i = 0; i < grid.Length; i++)
{
    for (var j = 0; j < grid[i].Length; j++)
    {
        if (grid[i][j] == '[')
        {
            score += 100 * i + j;
        }
    }
}

Console.WriteLine($"Score: {score}");

int? FindSpaceHorizontal(int dCol, int row, int col)
{
    if (col + dCol < 1 || col + dCol >= grid[0].Length - 1)
    {
        return null;
    }

    if (grid[row][col + dCol] == '#')
    {
        return null;
    }

    if (grid[row][col + dCol] == '.')
    {
        return col + dCol;
    }

    if (grid[row][col + dCol] == '[' || grid[row][col + dCol] == ']')
    {
        return FindSpaceHorizontal(dCol, row, col + dCol);
    }

    Console.WriteLine("Should have hit wall");
    return null;
}

bool CanMoveVertical(int dRow, int row, int col, HashSet<(int row, int col)> boxes)
{
    if (row + dRow < 1 || row + dRow >= grid.Length - 1)
    {
        return false;
    }

    if (grid[row + dRow][col] == '#')
    {
        return false;
    }

    if (grid[row + dRow][col] == '.')
    {
        return true;
    }

    if (grid[row + dRow][col] == '[')
    {
        var left = CanMoveVertical(dRow, row + dRow, col, boxes);
        var right = CanMoveVertical(dRow, row + dRow, col + 1, boxes);

        if(left && right)
        {
            boxes.Add((row + dRow, col));
        }

        return left && right;
    }

    if (grid[row + dRow][col] == ']')
    {
        var right = CanMoveVertical(dRow, row + dRow, col, boxes);
        var left = CanMoveVertical(dRow, row + dRow, col - 1, boxes);

        if (left && right)
        {
            boxes.Add((row + dRow, col - 1));
        }

        return left && right;
    }

    Console.WriteLine("Should have hit wall");
    return false;
}

(int row, int col) FindStart()
{
    for (var i = 0; i < grid.Length; i++)
    {
        for (var j = 0; j < grid[i].Length; j++)
        {
            if (grid[i][j] == '@')
            {
                return (i, j);
            }
        }
    }

    Console.WriteLine("Start not found");
    return (-1, -1);
}

int GetGpsValue(int row, int col)
{
    return row * 100 + col;
}

char[][] ExpandInput(char[][] input)
{
    var grid = new List<List<char>>();
    
    for (var i = 0;i < input.Length; i++)
    {
        var row = new List<char>();
        for(var j = 0;j < input[i].Length; j++)
        {
            if(input[i][j] == '#')
            {
                row.Add('#');
                row.Add('#');
            }

            if (input[i][j] == 'O')
            {
                row.Add('[');
                row.Add(']');
            }

            if (input[i][j] == '.')
            {
                row.Add('.');
                row.Add('.');
            }

            if (input[i][j] == '@')
            {
                row.Add('@');
                row.Add('.');
            }
        }

        grid.Add(row);
    }

    return grid.Select(c => c.ToArray()).ToArray();
}