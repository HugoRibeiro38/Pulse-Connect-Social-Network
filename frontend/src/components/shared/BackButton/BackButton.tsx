import { ArrowLeft } from 'lucide-react';
import Link from 'next/link';

import { buttonVariants } from '@/components/ui/button';

type BackButtonProps = {
	url: string;
};

const BackButton: React.FunctionComponent<BackButtonProps> = ({
	url,
}): React.ReactNode => {
	return (
		<Link
			href={url}
			className={`${buttonVariants({
				variant: 'ghost',
				size: 'icon',
			})}`}>
			<ArrowLeft />
		</Link>
	);
};

export default BackButton;
