package AutoHamster::FoodEater;
use strict; use warnings;
use parent qw[ Exporter ];

our @EXPORT = qw[ eat ];


sub eat {
    my ($filename) = @_;
    open (my $food, '<:utf8', $filename) or die "Cannot eat file\r\n $!";
    my @lines = <$food>;
    close $food;

    my @result = ( );

    foreach my $line (@lines) {
        chomp $line;
        my ($date, $title, $url, $description, 
            $category, $tags_line, $submitter) = split /\t/, $line;
        my $item = {
                     date        => $date, 
                     title       => $title, 
                     url         => $url, 
                     description => $description, 
                     category    => $category, 
                     submitter   => $submitter
                   };
        
       my @parsed_tags = split /,\s+/, $tags_line;
       $item->{'tags'} = \@parsed_tags;
       push @result, $item;
    }
    return @result;
}





"             .     .
            (>\---/<)
            ,'     `.
           /  q   p  \
          (  >(_Y_)<  )
           >-' `-' `-<-.
          /  _.== ,=.,- \
         /,    )`  '(    )
        ; `._.'      `--<
       :     \        |  )
       \      )       ;_/  hjw
        `._ _/_  ___.'-\\\
           `--\\\

http://www.retrojunkie.com/asciiart/animals/hamsters.htm
";
